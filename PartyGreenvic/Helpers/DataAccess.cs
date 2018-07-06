namespace PartyGreenvic.Helpers
{
    using Interfaces;
    using Models;
    using SQLite.Net;
    using SQLiteNetExtensions.Extensions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Xamarin.Forms;
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;
        public DataAccess()
        {
            try
            {
                var config = DependencyService.Get<IConfig>();
                this.connection = new SQLiteConnection(config.Platform, Path.Combine(config.DirectoryBD, "PartysGreenvic.db3"));
                connection.CreateTable<Empleado>();
            }
            catch (Exception ex)
            {
                ex.ToString();
                return;
            }
        }
        public void InsertarEmpleado(Empleado empleado)
        {
            try
            {
                this.connection.Insert(empleado);
            }
            catch (Exception ex)
            {
                ex.ToString();
                return;
            }
        }
        public void BorrarEmpleado(Empleado empleado)
        {
            this.connection.Delete(empleado);
        }
        public void ActualizarEmpleado(Empleado empleado)
        {
            this.connection.Update(empleado);
        }
        public Empleado GetEmpleado(string Rut)
        {
            return connection.Table<Empleado>().FirstOrDefault(c => c.Rut == Rut);
        }
        public List<Empleado> GetEmpleados()
        {
            return connection.Table<Empleado>().OrderBy(c => c.Nombre).ToList();
        }
        public Empleado BuscarEmpleado(string Rut)
        {
            return connection.Table<Empleado>().FirstOrDefault(c => c.Rut == Rut);
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
