namespace ExtensaoDeMetodos.Extension
{
    static  class ExtensaoDeStrings
    {
        public static string Cut(this string mesmoObjeto, int numero)
        {
            if (mesmoObjeto.Length <= numero )
            {
                return mesmoObjeto;
            }
            else
            {
                return mesmoObjeto.Substring( 0, numero ) + "...";  
            }
        }
    }
}
