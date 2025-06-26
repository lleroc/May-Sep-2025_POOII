using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Relaciones.Presenter
{
    
    public class ProvinciaPresenter
    {
        private readonly View.Provincias.IProvinciaView _vista;
        private readonly string _cadenaconexion = "server=localhost;uid=root;pwd=root;database=cuarto_maysep2025";
        public ProvinciaPresenter(View.Provincias.IProvinciaView provinciaView)
        {
            _vista = provinciaView;

            _vista.GuardarClicked += OnGuardar;
            _vista.EditarCliked += OnEditar;
            _vista.EliminarClicked += OnEliminar;

            CargaPises();
            CargaProvincias();
        }

       
        public void OnGuardar(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(_vista.nombre) || _vista.id_pais == 0)
            {
                _vista.MostrarMensajes("Debe completar los campos");
                return;
            }
            try
            {
                var cn = new MySqlConnection(_cadenaconexion);
                cn.Open();
                string cadena = "INSERT INTO `provincias`(`nombre`, `id_pais`) VALUES (@nombre,@id_pais)";
                var cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@nombre", _vista.nombre);
                cmd.Parameters.AddWithValue("@id_pais", _vista.id_pais);

                cmd.ExecuteNonQuery();
                _vista.MostrarMensajes("Se guarrdo con exito");
                _vista.LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _vista.MostrarMensajes($"Error al guardar. {ex}");
            }
        }
        public void OnEditar(object sender, EventArgs e) {
            if (_vista.id_provincia == 0)
            {
                _vista.MostrarMensajes("debe selecionar una provincia");
                return;

            }
            if (string.IsNullOrWhiteSpace(_vista.nombre) || _vista.id_pais == 0)
            {
                _vista.MostrarMensajes("Debe completar los campos");
                return;
            }
            try
            {
                var cn = new MySqlConnection(_cadenaconexion);
                cn.Open();
                string cadena = "UPDATE `provincias` SET `nombre`=@nombre,`id_pais`=@id_pais WHERE `id`= @id_provincia";
                var cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@nombre", _vista.nombre);
                cmd.Parameters.AddWithValue("@id_pais", _vista.id_pais);
                cmd.Parameters.AddWithValue("@id_provincia", _vista.id_provincia);

                cmd.ExecuteNonQuery();
                _vista.MostrarMensajes("Se guarrdo con exito");
                _vista.LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _vista.MostrarMensajes($"Error al guardar. {ex}");
            }
        }
        public void OnEliminar(object sender, EventArgs e) {
            if (_vista.id_provincia == 0)
            {
                _vista.MostrarMensajes("debe selecionar una provincia");
                return;
            }
            try
            {
                var cn = new MySqlConnection(_cadenaconexion);
                cn.Open();
                string cadena = "DELETE FROM `provincias` WHERE `id`= @id_provincia";
                var cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@id_provincia", _vista.id_provincia);
                cmd.ExecuteNonQuery();
                _vista.MostrarMensajes("Se guarrdo con exito");
                _vista.LimpiarFormulario();
            }
            catch (Exception ex)
            {
                _vista.MostrarMensajes($"Error al guardar. {ex}");
            }
        }
        public void CargaPises() {
            var paises = new List<Model.PaisModel>();
            var cn = new MySqlConnection(_cadenaconexion);
            cn.Open();
            string cadena = "SELECT * FROM `paises`";
            var cmd = new MySqlCommand(cadena, cn);
            var lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                paises.Add(new Model.PaisModel {
                    id = lector.GetInt32("id"),
                    nombre = lector.GetString("nombre")
                });
            }
            _vista.TodosPaises(paises);
        }
        public void CargaProvincias() {
            var provincias = new List<Model.ProvinciaModel>();
            var cn = new MySqlConnection(_cadenaconexion);
            cn.Open();
            string cadena = "SELECT * FROM `provincias`";
            var cmd = new MySqlCommand(cadena, cn);
            var lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                provincias.Add(new Model.ProvinciaModel
                {
                    id = lector.GetInt32("id"),
                    nombre = lector.GetString("nombre"),
                    id_pais = lector.GetInt32("id_pais")
                });
            }
            _vista.TodosProvincias(provincias);
        }

    }
}
