using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATM;
public class MainForm : Form
{
    private TextBox txtUser;
    private TextBox txtPass;
    private Button btnLogin;
    private Label lblStatus;
    private Panel atmPanel;
    private Label lblBalance;
    private TextBox txtAmount;
    private Button btnDeposit;
    private Button btnWithdraw;
    private Button btnCheck;
    private Button btnLogout;

    private int rights = 3;
    private int balance = 1500;

    public MainForm()
    {
        Text = "FurkanBank ATM";
        ClientSize = new Size(420, 260);
        StartPosition = FormStartPosition.CenterScreen;
        InitializeLoginControls();
        InitializeAtmPanel();
    }

    private void InitializeLoginControls()
    {
        var lblUser = new Label { Text = "Kullanýcý Adýnýz:", Location = new Point(20, 20), AutoSize = true };
        txtUser = new TextBox { Location = new Point(150, 16), Width = 240 };

        var lblPass = new Label { Text = "Parolanýz:", Location = new Point(20, 60), AutoSize = true };
        txtPass = new TextBox { Location = new Point(150, 56), Width = 240, UseSystemPasswordChar = true };

        btnLogin = new Button { Text = "Giriþ Yap", Location = new Point(150, 96), Width = 100 };
        btnLogin.Click += BtnLogin_Click;

        lblStatus = new Label { Text = $"Kalan Hakkýnýz: {rights}", Location = new Point(20, 140), AutoSize = true, ForeColor = Color.DarkBlue };

        Controls.AddRange(new Control[] { lblUser, txtUser, lblPass, txtPass, btnLogin, lblStatus });
    }

    private void InitializeAtmPanel()
    {
        atmPanel = new Panel { Location = new Point(10, 10), Size = new Size(400, 220), Visible = false };

        lblBalance = new Label { Text = $"Bakiyeniz: {balance} TL", Location = new Point(10, 10), AutoSize = true, Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold) };

        var lblAmount = new Label { Text = "Miktar (TL):", Location = new Point(10, 40), AutoSize = true };
        txtAmount = new TextBox { Location = new Point(100, 36), Width = 120 };

        btnDeposit = new Button { Text = "Para Yatýr", Location = new Point(240, 34), Width = 120 };
        btnDeposit.Click += BtnDeposit_Click;

        btnWithdraw = new Button { Text = "Para Çek", Location = new Point(240, 74), Width = 120 };
        btnWithdraw.Click += BtnWithdraw_Click;

        btnCheck = new Button { Text = "Bakiye Sorgula", Location = new Point(10, 74), Width = 200 };
        btnCheck.Click += BtnCheck_Click;

        btnLogout = new Button { Text = "Çýkýþ Yap", Location = new Point(10, 120), Width = 350 };
        btnLogout.Click += BtnLogout_Click;

        atmPanel.Controls.AddRange(new Control[] { lblBalance, lblAmount, txtAmount, btnDeposit, btnWithdraw, btnCheck, btnLogout });
        Controls.Add(atmPanel);
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        var user = txtUser.Text.Trim();
        var pass = txtPass.Text;

        if (user == "Furkan" && pass == "7413002MFYM")
        {
            lblStatus.Text = "Giriþ baþarýlý. Hoþgeldiniz!";
            ShowAtmPanel();
        }
        else
        {
            rights--;
            if (rights <= 0)
            {
                MessageBox.Show("Hesabýnýz bloke olmuþtur, lütfen banka ile iletiþime geçiniz.", "Bloke", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLogin.Enabled = false;
                lblStatus.Text = "Hesap bloke.";
            }
            else
            {
                lblStatus.Text = $"Hatalý kullanýcý adý veya þifre. Kalan Hakkýnýz: {rights}";
            }
        }
    }

    private void ShowAtmPanel()
    {
        foreach (Control c in Controls)
        {
            if (c != atmPanel) c.Visible = false;
        }
        atmPanel.Visible = true;
        UpdateBalanceLabel();
    }

    private void BtnDeposit_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtAmount.Text.Trim(), out int amount) && amount > 0)
        {
            balance += amount;
            UpdateBalanceLabel();
            MessageBox.Show($"{amount} TL para yatýrýldý.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void BtnWithdraw_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtAmount.Text.Trim(), out int amount) && amount > 0)
        {
            if (amount > balance)
            {
                MessageBox.Show("Bakiye yetersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                balance -= amount;
                UpdateBalanceLabel();
                MessageBox.Show($"{amount} TL para çekildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void BtnCheck_Click(object? sender, EventArgs e)
    {
        MessageBox.Show($"Bakiyeniz: {balance} TL", "Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnLogout_Click(object? sender, EventArgs e)
    {
        atmPanel.Visible = false;
        foreach (Control c in Controls) c.Visible = true;
        txtPass.Clear();
        txtAmount.Clear();
        lblStatus.Text = $"Kalan Hakkýnýz: {rights}";
    }

    private void UpdateBalanceLabel() => lblBalance.Text = $"Bakiyeniz: {balance} TL";
}