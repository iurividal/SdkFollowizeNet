using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdkFollowizeNet.Models
{
    public class Lead
    {
        public string clientKey { get; set; }

        public string teamKey { get; set; }

        public string conversionGoal { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string cellPhone { get; set; }

        public string attendantId { get; set; }

        /// <summary>
        ///E-mail do atendente que irá receber o Lead. Obs.: Se identificar o atendente, o rodízio na equipe será ignorad
        /// </summary>
        public string attendantEmail { get; set; }

        public string message { get; set; }

        /// <summary>
        /// Endereço do cliente.
        /// </summary>
        public string addressLine1 { get; set; }


        /// <summary>
        /// Complemento do endereço do cliente.
        /// </summary>
        public string addressLine2 { get; set; }

        /// <summary>
        /// Bairro do cliente.
        /// </summary>
        public string neighborhood { get; set; }

        /// <summary>
        /// Cidade do cliente.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Estado do cliente.
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// País do cliente.
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// CEP do cliente.
        /// </summary>
        public string zipCode { get; set; }

        /// <summary>
        /// CPF do cliente.
        /// </summary>
        public string registrationNumber { get; set; }

        /// <summary>
        /// Cargo do cliente.
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// Nome da empresa do cliente.
        /// </summary>
        public string companyName { get; set; }

        public string brandId { get; set; }


        public Lead(string clientKey, string empresa, string conversionGoal, string name, string message, string phone, string email = "")
        {


            this.clientKey = clientKey;
            this.teamKey = Utils.GetKeyTeam(empresa);
            this.conversionGoal = conversionGoal;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.message = message;
            this.brandId = empresa.GetBrandId();
        }


        public Lead(string clientKey, string empresa, string conversionGoal, string name, string message, string cellPhone, string email = "", string phone = "")
        {
            this.clientKey = clientKey;
            this.teamKey = Utils.GetKeyTeam(empresa);
            this.conversionGoal = conversionGoal;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.cellPhone = cellPhone;
            this.message = message;
            this.brandId = empresa.GetBrandId();
        }
    }


}
