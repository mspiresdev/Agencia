using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace AgenciaWebApi
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            try
            {
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                //usuario e senha
                //context.UserName
                //context.Password
                AgenciaDAL.Pessoa PessoaDAL = new AgenciaDAL.Pessoa();
                AgenciaModel.Usuario user = PessoaDAL.AcessoUsuario(context.UserName, context.Password);
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Usu));
                var roles = new List<string>();
                roles.Add(user.Perfis.OrderBy(u=> u.Hieranquia).FirstOrDefault().Nome);

                foreach (var role in roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                GenericPrincipal principal = new GenericPrincipal(identity, roles.ToArray());
                Thread.CurrentPrincipal = principal;

                context.Validated(identity);


            }
            catch (Exception)
            {
                context.SetError("invalid_grant", "Erro na Autenticação");
            }
        }

        private void SetError(OAuthGrantResourceOwnerCredentialsContext context, string txt)
        {
            context.SetError("invalid_grant", txt);
        }
    }
}