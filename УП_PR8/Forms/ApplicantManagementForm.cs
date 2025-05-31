using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using УП_PR8.Forms;

namespace УП_PR8
{
    public partial class ApplicantManagementForm : Form
    {
        private readonly string connectionString = "Host=localhost;Database=job_center;Username=postgres;Password=123;Port=5433";

        public ApplicantManagementForm()
        {
            InitializeComponent();
            panelVacancyDetails.BackColor = System.Drawing.Color.FromArgb(250, 179, 132); // #FAB384 - дополнительный фон
            labelCompany.ForeColor = System.Drawing.Color.Black;
            labelPosition.ForeColor = System.Drawing.Color.Black;
            labelDriving.ForeColor = System.Drawing.Color.Black;
            labelLanguages.ForeColor = System.Drawing.Color.Black;
            labelOtherInfo.ForeColor = System.Drawing.Color.Black;
            labelDuties.ForeColor = System.Drawing.Color.Black;
            labelConditions.ForeColor = System.Drawing.Color.Black;
            buttonViewApplicants.BackColor = System.Drawing.Color.FromArgb(0, 147, 53); // #009335 - акцентирование
            buttonViewApplicants.ForeColor = System.Drawing.Color.White;
            LoadData();
            PopulateControls();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Загрузка компаний
                    string companyQuery = @"SELECT DISTINCT v.organization FROM vacancies v";
                    using (var cmd = new NpgsqlCommand(companyQuery, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBoxCompany.Items.Clear();
                        while (reader.Read())
                        {
                            string company = reader["organization"].ToString();
                            if (!string.IsNullOrEmpty(company))
                                comboBoxCompany.Items.Add(company);
                        }
                    }

                    // Загрузка соискателей
                    UpdateApplicantList(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateControls()
        {
            if (comboBoxCompany.Items.Count > 0) comboBoxCompany.SelectedIndex = 0;
            UpdatePositions();
            if (comboBoxPosition.Items.Count > 0) comboBoxPosition.SelectedIndex = 0;
            UpdateVacancyDetails();
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePositions();
            UpdateVacancyDetails();
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVacancyDetails();
        }

        private void UpdatePositions()
        {
            string selectedCompany = comboBoxCompany.SelectedItem?.ToString();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT v.position FROM vacancies v WHERE v.organization = @company";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("company", NpgsqlTypes.NpgsqlDbType.Varchar).Value = selectedCompany ?? (object)DBNull.Value;
                    comboBoxPosition.Items.Clear();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string position = reader["position"].ToString();
                            if (!string.IsNullOrEmpty(position))
                                comboBoxPosition.Items.Add(position);
                        }
                    }
                }
            }
        }

        private void UpdateVacancyDetails()
        {
            string selectedCompany = comboBoxCompany.SelectedItem?.ToString();
            string selectedPosition = comboBoxPosition.SelectedItem?.ToString();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT v.address AS address, v.driving_license, v.languages, 
                    v.other_info, v.duties, v.conditions 
                    FROM vacancies v 
                    WHERE v.organization = @company AND v.position = @position";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("company", NpgsqlTypes.NpgsqlDbType.Varchar).Value = selectedCompany ?? (object)DBNull.Value;
                    cmd.Parameters.AddWithValue("position", NpgsqlTypes.NpgsqlDbType.Varchar).Value = selectedPosition ?? (object)DBNull.Value;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelDriving.Text = "Вод.права: " + (reader["driving_license"]?.ToString() ?? "");
                            labelLanguages.Text = "Иностранные языки: " + (reader["languages"]?.ToString() ?? "");
                            labelOtherInfo.Text = "Др.информация: " + (reader["other_info"]?.ToString() ?? "");
                            labelDuties.Text = "Должностные обязанности: " + (reader["duties"]?.ToString() ?? "");
                            labelConditions.Text = "Условия труда: " + (reader["conditions"]?.ToString() ?? "");
                        }
                    }
                }
            }
            UpdateApplicantList();
        }

        private void UpdateApplicantList()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    UpdateApplicantList(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить список соискателей: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateApplicantList(NpgsqlConnection conn)
        {
            flowLayoutPanelApplicants.Controls.Clear();
            string selectedPosition = comboBoxPosition.SelectedItem?.ToString();
            string query = @"SELECT a.applicant_id, a.applicant_name AS fio, EXTRACT(YEAR FROM AGE(a.birth_date)) AS age, 
                a.gender, a.position, a.education, a.qualification, a.desired_salary, v.address, v.phone, 
                a.fill_date, r.status
                FROM applicants a LEFT JOIN reservations r ON a.applicant_id = r.applicant_id
                LEFT JOIN vacancies v ON r.vacancy_id = v.vacancy_id
                WHERE a.position = @position";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("position", NpgsqlTypes.NpgsqlDbType.Varchar).Value = selectedPosition ?? (object)DBNull.Value;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Panel panel = CreateApplicantPanel(reader);
                        flowLayoutPanelApplicants.Controls.Add(panel);
                    }
                }
            }
        }

        private Panel CreateApplicantPanel(NpgsqlDataReader reader)
        {
            Panel panel = new Panel()
            {
                Size = new Size(715, 225),
                AutoScroll = true,
                BorderStyle = BorderStyle.Fixed3D,
                Margin = new Padding(10),
                BackColor = System.Drawing.Color.FromArgb(250, 179, 132), // #FAB384 - дополнительный фон
                Cursor = Cursors.Hand
            };
            panel.DoubleClick += (s, e) => OpenApplicantEditForm();

            Label Fio = new Label()
            {
                Location = new Point(10, 10),
                Text = reader["fio"].ToString(),
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Age = new Label()
            {
                Location = new Point(10, 30),
                Text = $"Возраст: {reader["age"]}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Gender = new Label()
            {
                Location = new Point(10, 50),
                Text = $"Пол: {reader["gender"]}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Position = new Label()
            {
                Location = new Point(10, 70),
                Text = $"Должность: {reader["position"]}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Education = new Label()
            {
                Location = new Point(10, 90),
                Text = $"Образование: {reader["education"]?.ToString() ?? ""}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Qualification = new Label()
            {
                Location = new Point(10, 110),
                Text = $"Квалификация: {reader["qualification"]?.ToString() ?? ""}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Salary = new Label()
            {
                Location = new Point(10, 130),
                Text = $"Предполагаемая з/п: {reader["desired_salary"]?.ToString() ?? ""}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label FillDate = new Label()
            {
                Location = new Point(10, 150),
                Text = $"Дата заполнения: {reader["fill_date"]?.ToString() ?? ""}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            Label Status = new Label()
            {
                Location = new Point(10, 170),
                Text = $"Статус: {(reader["status"] != DBNull.Value ? reader["status"].ToString() : "рассмотрение")}",
                AutoSize = true,
                Font = new Font("Times New Roman", 14),
            };

            panel.Controls.Add(Fio);
            panel.Controls.Add(Age);
            panel.Controls.Add(Gender);
            panel.Controls.Add(Position);
            panel.Controls.Add(Education);
            panel.Controls.Add(Qualification);
            panel.Controls.Add(Salary);
            panel.Controls.Add(FillDate);
            panel.Controls.Add(Status);

            return panel;
        }

        private void OpenApplicantEditForm()
        {
            ApplicantEditForm editForm = new ApplicantEditForm();
            editForm.FormClosed += (s, args) => LoadData();
            editForm.Show();
            this.Hide();
        }

        private void buttonViewApplicants_Click(object sender, EventArgs e)
        {
            UpdateApplicantList();
        }

        private void ApplicantManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

