using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clases.User{

    class User{

        private string idUser;
        private string ? userName;
        private string ? password;

        public string IdUser{get => this.idUser ?? String.Empty; set => this.idUser = value;}

        public string UserName {get => this.userName ?? String.Empty; set => userName = value;}

        public string Password{get => this.password ?? String.Empty; set => password =value;}

        public User(string idUser, string userName, string password) {

            this.idUser = GenerateShortId(Guid.NewGuid().ToString());
            this.userName = userName;
            this.password = password;

        }

        public User(){
            this.idUser = GenerateShortId(Guid.NewGuid().ToString());
        }

        public static string GenerateShortId(string input){

            using (SHA256 sha256 = SHA256.Create()){

                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                string base64String = Convert.ToBase64String(hashBytes);
                string shortId = base64String.Substring(0,8);
                return shortId;

            }

        }

        //Validar email regex
        public bool IsValidEmail(string email){

            if(string.IsNullOrWhiteSpace(email)){

                return false;

            }

            try{

                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match){
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }

            }
            catch(RegexMatchTimeoutException){
                return false;
            }
            catch(ArgumentException){
                return false;
            }
            
            try{

                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            }catch(RegexMatchTimeoutException){

                return false;

            }

        }

    }

}