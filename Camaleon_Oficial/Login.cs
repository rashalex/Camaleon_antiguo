using Dominio;
using Presentacion;
using Common.Cache;

namespace Camaleon_Oficial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        //boton Ingresar
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //if (txtusu.Text != "USUARIO")
            //{
                /*if (txtpass.Text != "CONTRASE�A")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtusu.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        formPrincipal mainMenu = new formPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();

                    }
                    else
                    {
                        msgError("Usuario y/o contrasela incorrecta. \n Por favor intenta de nuevo.");
                        txtpass.Clear();
                        txtusu.Focus();
                    }
                }
                else msgError("Por favor ingrese contrase�a.");
            } else msgError("Por favor ingrese usuario.");*/
                if (txtusu.Text != "") //si usuario esta lleno se ejecuta
                {
                    if (txtpass.Text != "")//si contrase�a esta llena se ejecuta
                    {
                        UserModel user = new UserModel(); //instanciar de dominio
                        var validLogin = user.LoginUser(txtusu.Text, txtpass.Text);//variable, para validar login, llega los valores de txt
                        if (validLogin == true)//si son datos correctos
                        {
                            //entra a men� 
                            formPrincipal mainMenu = new formPrincipal();
                            this.Hide(); //se oculta el logeo
                            mainMenu.FormClosed += Logout;//cerrar login y se ejecuta el metodo logout
                            mainMenu.Show();

                            //MessageBox.Show("Ususario correcto");
                        }
                        else
                        {
                            //si son datos incorrectos

                            msgError("Datos Incorrectos \n Intente de nuevo");
                            txtpass.Text = "";
                            txtusu.Focus();
                        }
                    }
                    else//contrase�a vacia
                    {
                        msgError("Ingrese la contrase�a");
                    }
                }
                else//usuario vacio 
                {
                    msgError("Ingrese el usuario");
                }
            //}
        }
        private void msgError(string msg)
        {
            lblMensajeError.Text = msg;
            lblMensajeError.Visible = true;
        }
        private void txtusu_Enter(object sender, EventArgs e)
        {
            if (txtusu.Text == "USUARIO")
            {
                txtusu.Text = "";
                txtusu.ForeColor = Color.LightGray;
                
            }
        }

        private void txtusu_Leave(object sender, EventArgs e)
        {
            if(txtusu.Text == "")
            {
                txtusu.Text = "USUARIO";
                txtusu.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASE�A")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
           
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASE�A";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
                
            }
        }

        

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASE�A";
            txtpass.UseSystemPasswordChar = false;
            txtusu.Text = "USUARIO";
            lblMensajeError.Visible = false;
            this.Show();
        }
        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtpass.UseSystemPasswordChar = true;
            /*if (txtpass.PasswordChar == '\0')
            {
                pbOcultar.BringToFront();
                txtpass.PasswordChar = '*';
            }*/
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtpass.UseSystemPasswordChar = false;
            /*if (txtpass.PasswordChar == '*')
            {
                pbOcultar.BringToFront();
                txtpass.PasswordChar = '\0';
            }*/
        }

        private void lblMensajeError_Click(object sender, EventArgs e)
        {

        }
    }
}