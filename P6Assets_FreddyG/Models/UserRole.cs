﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace P6Assets_FreddyG.Models {
    public class UserRole {

        public RestRequest? request { get; set; }
        public int UserRoleId { get; set; }
        public string UserRoleDescription { get; set; } = null!;

        public async Task<List<UserRole>?> GetAllUserRolesAsync() {
            try {
                string RouterSufix = string.Format("UserRoles");
                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

                RestClient client = new RestClient(URL);
                request = new RestRequest(URL, Method.Get);
                request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK) {
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);
                    return list;
                } else {
                    return null;
                }
            } catch (Exception ex) {
                string ErrorMsg = ex.Message;
                throw;
            }
        }
    }
}
