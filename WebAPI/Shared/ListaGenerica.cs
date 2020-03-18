namespace WebAPI.Shared
{
    public class ListaGenerica
    {
        public class StringString
        {
            public virtual string Id { get; set; }
            public string Descricao { get; set; }
            public string DescricaoTruncada { get; set; }
            public string DescricaoParaGrid
            {
                get
                {
                    return Id != null && Descricao != null ? Id + " - " + Descricao : "";
                }
            }

            public StringString()
            { }
            public StringString(string key, string value)
            {
                this.Id = key;
                this.Descricao = value;
            }
        }
    }
}
