using System;

namespace ConsoleLerArqLog.Entities
{
    class RegistroLog
    {
        public string Usuario { get; set; }
        public DateTime Instante { get; set; }

        public RegistroLog(string usuario, DateTime instante)
        {
            Usuario = usuario;
            Instante = instante;
        }

        public override int GetHashCode()
        {
            return Usuario.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RegistroLog))
            {
                return false;
            }

            RegistroLog other = obj as RegistroLog; //downcasting
            return Usuario.Equals(other.Usuario);
        }
    }
}
