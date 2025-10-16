using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MindfulnessApp
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnLogin;
        private Button btnRegister;
        private ListBox lstUsers;
        private List<User> users = new();
        private readonly string filePath = "users.txt";

        public LoginForm()
        {
            Text = "Mindfulness App Login";
            Width = 400;
            Height = 420;

            Label lblUsername = new Label() { Text = "Username:", Left = 20, Top = 20 };
            txtUsername = new TextBox() { Left = 120, Top = 20, Width = 200 };

            Label lblEmail = new Label() { Text = "Email:", Left = 20, Top = 60 };
            txtEmail = new TextBox() { Left = 120, Top = 60, Width = 200 };

            btnRegister = new Button() { Text = "Register", Left = 120, Top = 100, Width = 90 };
            btnRegister.Click += BtnRegister_Click;

            btnLogin = new Button() { Text = "Login", Left = 230, Top = 100, Width = 90 };
            btnLogin.Click += BtnLogin_Click;

            lstUsers = new ListBox() { Left = 20, Top = 150, Width = 330, Height = 200 };

            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lstUsers);

            LoadUsersFromFile();
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            string name = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter both name and email.");
                return;
            }

            if (users.Any(u => u.Username.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("User already exists!");
                return;
            }

            var user = new User(name, email);
            users.Add(user);
            lstUsers.Items.Add(user);
            SaveUsersToFile();
            MessageBox.Show("User registered successfully!");
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string name = txtUsername.Text.Trim();
            var user = users.FirstOrDefault(u => u.Username.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                MessageBox.Show("User not found. Please register first.");
                return;
            }

            Hide();
            new MainForm(user).ShowDialog();
            Show();
        }

        private void SaveUsersToFile()
        {
            using StreamWriter sw = new StreamWriter(filePath);
            foreach (var u in users)
                sw.WriteLine(u.ToFileFormat());
        }

        private void LoadUsersFromFile()
        {
            if (!File.Exists(filePath)) return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var user = User.FromFileFormat(line);
                if (user != null)
                {
                    users.Add(user);
                    lstUsers.Items.Add(user);
                }
            }
        }
    }
}
