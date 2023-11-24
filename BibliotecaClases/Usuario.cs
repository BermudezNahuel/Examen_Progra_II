namespace BibliotecaClases
{
    public class Usuario
    {

        //Atributos de la clase
        private string? _contrasenia;
        private string? _nombre;
        private string? _apellido;
        private string _dni;
        private string? _direccion_correo;
        private string? _direccion;
        private DateOnly _fecha_nacimiento;
        private string? _telefono;
        private int _legajo;


        //Declaro getters y setters
        public int Legajo { get => _legajo; set => _legajo = value; }
        public string? Contrasenia { get => _contrasenia; }
        public string? Nombre { get => _nombre; set => _nombre = value; }
        public string? Apellido { get => _apellido; }
        public string Dni { get => _dni; }
        public string? Direcion_correo { get => _direccion_correo; }
        public string? Direccion { get => _direccion; }
        public DateOnly Fecha_nacimiento { get => _fecha_nacimiento; }
        public string? Telefono { get => _telefono; }

        //Constructor

        public Usuario(string contrasenia, string nombre, string apellido, string dni, string direccion_correo, string direccion, string fecha_nacimiento, string telefono)
        {
            _contrasenia = contrasenia;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion_correo = direccion_correo;
            _direccion = direccion;
            _fecha_nacimiento = DateOnly.Parse(fecha_nacimiento);
            _telefono = telefono;
        }

    }
}