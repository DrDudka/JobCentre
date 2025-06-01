using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace УП_PR8.Forms
{
    public partial class ApplicantEditForm : Form
    {
        private readonly string connectionString = "Host=localhost;Database=job_center;Username=postgres;Password=123;Port=5433";
        private readonly List<TextBox> requiredTextBoxes = new List<TextBox>();
        private readonly int? applicantId;

        public ApplicantEditForm(int? applicantId = null)
        {
            this.applicantId = applicantId;
            InitializeComponent();
            LoadData();
            ConfigureDataGridView();
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM applicants ORDER BY fill_date";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        adapter.Fill(dt);

                        dataGridApplicants.DataSource = dt;
                        dataGridApplicants.Columns["applicant_id"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridApplicants.MultiSelect = false;
            dataGridApplicants.ReadOnly = true;

            dataGridApplicants.Columns["applicant_name"].HeaderText = "ФИО";
            dataGridApplicants.Columns["birth_date"].HeaderText = "Дата рождения";
            dataGridApplicants.Columns["gender"].HeaderText = "Пол";
            dataGridApplicants.Columns["position"].HeaderText = "Должность";
            dataGridApplicants.Columns["education"].HeaderText = "Образование";
            dataGridApplicants.Columns["qualification"].HeaderText = "Квалификация";
            dataGridApplicants.Columns["experience"].HeaderText = "Опыт работы";
            dataGridApplicants.Columns["desired_salary"].HeaderText = "Предполагаемая з/п";
            dataGridApplicants.Columns["other_info"].HeaderText = "Другая информация";
            dataGridApplicants.Columns["fill_date"].HeaderText = "Дата заполнения";
        }

        private void dataGridApplicants_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridApplicants.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridApplicants.SelectedRows[0];

                textBoxFio.Text = row.Cells["applicant_name"].Value != DBNull.Value ? row.Cells["applicant_name"].Value.ToString() : string.Empty;
                dateTimePickerBirthDate.Value = row.Cells["birth_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["birth_date"].Value)
                    : DateTime.Now;
                textBoxGender.Text = row.Cells["gender"].Value != DBNull.Value ? row.Cells["gender"].Value.ToString() : string.Empty;
                textBoxPosition.Text = row.Cells["position"].Value != DBNull.Value ? row.Cells["position"].Value.ToString() : string.Empty;
                textBoxEducation.Text = row.Cells["education"].Value != DBNull.Value ? row.Cells["education"].Value.ToString() : string.Empty;
                textBoxQualification.Text = row.Cells["qualification"].Value != DBNull.Value ? row.Cells["qualification"].Value.ToString() : string.Empty;
                textBoxExperience.Text = row.Cells["experience"].Value != DBNull.Value ? row.Cells["experience"].Value.ToString() : string.Empty;
                textBoxSalary.Text = row.Cells["desired_salary"].Value != DBNull.Value ? row.Cells["desired_salary"].Value.ToString() : string.Empty;
                textBoxOtherInfo.Text = row.Cells["other_info"].Value != DBNull.Value ? row.Cells["other_info"].Value.ToString() : string.Empty;
                dateTimePickerFillDate.Value = row.Cells["fill_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["fill_date"].Value)
                    : DateTime.Now;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (requiredTextBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (applicantId.HasValue || dataGridApplicants.SelectedRows.Count > 0)
            {
                int selectedApplicantId = applicantId.HasValue
                    ? applicantId.Value
                    : Convert.ToInt32(dataGridApplicants.SelectedRows[0].Cells["applicant_id"].Value);

                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"
                            UPDATE applicants 
                            SET 
                                applicant_name = @Fio,
                                birth_date = @BirthDate,
                                gender = @Gender,
                                position = @Position,
                                education = @Education,
                                qualification = @Qualification,
                                experience = @Experience,
                                desired_salary = @Salary,
                                other_info = @OtherInfo,
                                fill_date = @FillDate
                            WHERE applicant_id = @ApplicantId";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ApplicantId", selectedApplicantId);
                            command.Parameters.AddWithValue("@Fio", string.IsNullOrWhiteSpace(textBoxFio.Text) ? (object)DBNull.Value : textBoxFio.Text);
                            command.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthDate.Value);
                            command.Parameters.AddWithValue("@Gender", string.IsNullOrWhiteSpace(textBoxGender.Text) ? (object)DBNull.Value : textBoxGender.Text);
                            command.Parameters.AddWithValue("@Position", string.IsNullOrWhiteSpace(textBoxPosition.Text) ? (object)DBNull.Value : textBoxPosition.Text);
                            command.Parameters.AddWithValue("@Education", string.IsNullOrWhiteSpace(textBoxEducation.Text) ? (object)DBNull.Value : textBoxEducation.Text);
                            command.Parameters.AddWithValue("@Qualification", string.IsNullOrWhiteSpace(textBoxQualification.Text) ? (object)DBNull.Value : textBoxQualification.Text);
                            command.Parameters.AddWithValue("@Experience", string.IsNullOrWhiteSpace(textBoxExperience.Text) ? (object)DBNull.Value : Convert.ToInt32(textBoxExperience.Text));
                            command.Parameters.AddWithValue("@Salary", string.IsNullOrWhiteSpace(textBoxSalary.Text) ? (object)DBNull.Value : Convert.ToInt32(textBoxSalary.Text));
                            command.Parameters.AddWithValue("@OtherInfo", string.IsNullOrWhiteSpace(textBoxOtherInfo.Text) ? (object)DBNull.Value : (textBoxOtherInfo.Text));
                            command.Parameters.AddWithValue("@FillDate", dateTimePickerFillDate.Value);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные о соискателе обновлены!", "Успех");
                                LoadData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ApplicantManagementForm applicantManagementForm = new ApplicantManagementForm();
            applicantManagementForm.Show();
            this.Hide();
        }

        private void ApplicantEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Поле обязательно для заполнения");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void ApplicantEditForm_Load(object sender, EventArgs e)
        {
            requiredTextBoxes.Add(textBoxFio);
            requiredTextBoxes.Add(textBoxEducation);
            requiredTextBoxes.Add(textBoxQualification);
            requiredTextBoxes.Add(textBoxSalary);

            foreach (var textBox in requiredTextBoxes)
            {
                textBox.Validating += TextBox_Validating;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
    }
}
