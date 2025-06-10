namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public DateTime fechaDeNacimiento;
        public char estadoCivil;
        public DateTime fechaIngresoEnLaEmpresa;
        public double sueldoBasico;
        public Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaIngresoEnLaEmpresa, double sueldoBasico, Cargos cargo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngresoEnLaEmpresa = fechaIngresoEnLaEmpresa;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }
        public int Antiguedad
        {
            get => DateTime.Now.Year - fechaIngresoEnLaEmpresa.Year;
        }
        public int Edad
        {
            get => DateTime.Now.Year - fechaDeNacimiento.Year;
        }
        public int AniosParaJubilarse
        {
            get => 65 - Edad;
        }
        public double CalcularSalario()
        {
            double adicional = 0;
            if (Antiguedad <= 20)
                adicional += sueldoBasico * (Antiguedad * 0.01);
            else
                adicional += sueldoBasico * 0.25;

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
                adicional *= 1.5;
            if (estadoCivil == 'c')
                adicional += 150000;
            return sueldoBasico + adicional;
        }
    }
}