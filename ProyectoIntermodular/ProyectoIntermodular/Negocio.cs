using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace ProyectoIntermodular
{
    internal class Negocio
    {
        private readonly HttpClient httpClient = new HttpClient();

        public Negocio()
        {

        }
        public async Task<Profesor> Login(string user, string pwd)
        {
            string apiUrl = "http://localhost:8080/api/profesores/login/{user}?pwd="+pwd+"&user="+user;
            var response = await httpClient.PostAsync(apiUrl, null);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            Profesor profesor = JsonConvert.DeserializeObject<Profesor>(await response.Content.ReadAsStringAsync());

            return profesor;
        }



        public async Task<List<Profesor>> GetProfesores()
        {
            string apiUrl = "http://localhost:8080/api/profesores/listar";
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                List<Profesor> profesores = JsonConvert.DeserializeObject<List<Profesor>>(result);
                return profesores;
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron profesores.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                return null;
            }
        }

        public async Task<List<Guardia>> GetGuardiasProfesores(Profesor profesor)
        {
            string apiUrl = $"http://localhost:8080/api/guardias/getAllGuardias/{profesor.id}?id="+profesor.id;
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                List<Guardia> guardias = JsonConvert.DeserializeObject<List<Guardia>>(result);
                return guardias;
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron guardias.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                return null;
            }
        }


        public async Task<Profesor> ObtenerProfesorID(int id)
        {
            string apiUrl = $"http://localhost:8080/api/profesores/buscar/{id}";
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string profesorJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Profesor>(profesorJson);
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron profesores con el Id especificado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                return null;
            }
        }

        public async Task<bool> ObtenerPerfilProfesor(Profesor profesor)
        {
            string apiUrl = "http://localhost:8080/api/profesorTienePerfil/buscarPerfil/{profesor}?id="+profesor.id;
            //"http://localhost:8080/api/profesores/login/{user}?pwd=" + pwd + "&user=" + user;
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode && response.StatusCode==HttpStatusCode.OK)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Guardia> CrearGuardia(Guardia guardia)
        {
            string apiUrl = "http://localhost:8080/api/guardias/crear";
            var content = new StringContent(JsonConvert.SerializeObject(guardia).ToString(), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                return null;
            }

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Guardia>(responseContent);
        }


        public async Task CambiarEstadoGuardia(int id, string estado)
        {
            string apiUrl = $"http://localhost:8080/api/guardias/setEstado/{id}";
            var content = new StringContent(JsonConvert.SerializeObject(new{estado}), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron guardias con el Id especificado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        public async Task BorrarGuardia(int id)
        {
            string apiUrl = $"http://localhost:8080/api/guardias/borrar/{id}";
            var response = await httpClient.DeleteAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron guardias con el Id especificado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        public async Task ActualizarGuardia(Guardia guardia)
        {
            string apiUrl = $"http://localhost:8080/api/guardias/modificar/{guardia.Id}";
            var content = new StringContent(JsonConvert.SerializeObject(guardia), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron guardias con el Id especificado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        public async Task<List<Guardia>> ObtenerGuardias()
        {
            string apiUrl = "http://localhost:8080/api/guardias/listar";
            var response = await httpClient.GetAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return null;
            }

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Guardia>>(responseContent);
        }
        public async Task<Guardia> ObtenerGuardiaID(int id)
        {
            string apiUrl = $"http://localhost:8080/api/guardias/buscar/{id}";
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string guardiaJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Guardia>(guardiaJson);
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("La solicitud no es válida. Verifica los datos enviados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("No se encontraron guardias con el Id especificado.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                return null;
            }
        }
    }
}
