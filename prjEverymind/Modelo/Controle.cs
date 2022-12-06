using prjEverymind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace prjEverymind.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(String login, String senha)
        {
            loginDalComandos loginDal = new loginDalComandos();
            tem = loginDal.verificarLogin(login, senha);
            if (!loginDal.mensagem.Equals (""));
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }
        public string cadastrar(String email, String senha, String confSenha)
        {
            loginDalComandos loginDal = new loginDalComandos();
            this.mensagem = loginDal.cadastrar(email, senha, confSenha);
            if (loginDal.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }
        

        

    }
}
