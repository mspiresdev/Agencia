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

namespace AgenciaWebApI
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
                if (true)
                
                {
                    //token

                    String LdescToken = Firjan_Util.Util.DescriptografarToken(context.Password.Replace("0", "&"));
                    String[] LcolUsuario = LdescToken.Split('$');
                    Int32 LidCliente = Convert.ToInt32(LcolUsuario[0]);
                    DateTime LdtLogin = Convert.ToDateTime(LcolUsuario[1]);
                    String LdescLogin = LcolUsuario[2];
                    String LdescComputador = LcolUsuario[3];
                    Int16 LidSistema = Convert.ToInt16(LcolUsuario[4]);
                    Int16 LidUnidade = Convert.ToInt16(LcolUsuario[5]);
                    String LdescLogonWindows = LcolUsuario[6];
                   
                       
                                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                                identity.AddClaim(new Claim(ClaimTypes.Name, LidCliente.ToString()));
                                var roles = new List<string>();
                                roles.Add("Admin");

                                foreach (var role in roles)
                                {
                                    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                                }

                                GenericPrincipal principal = new GenericPrincipal(identity, roles.ToArray());
                                Thread.CurrentPrincipal = principal;

                                context.Validated(identity);
                            
                            
                                //var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                                //identity.AddClaim(new Claim(ClaimTypes.Name, LidCliente.ToString()));
                                //var roles = new List<string>();
                                //roles.Add("User");

                                //foreach (var role in roles)
                                //{
                                //    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                                //}

                                //GenericPrincipal principal = new GenericPrincipal(identity, roles.ToArray());
                                //Thread.CurrentPrincipal = principal;

                                //context.Validated(identity);
                            
                            
                                SetError(context, "Autenticação inválida Grupo de Sistema");
                        
                      
                    
                    
                }
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", "Autenticação inválida catch" + ex.Message);
            }
        }

        private void SetError(OAuthGrantResourceOwnerCredentialsContext context, string txt)
        {
            context.SetError("invalid_grant", txt);
        }
    }
}