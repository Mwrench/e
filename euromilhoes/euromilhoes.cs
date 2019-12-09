namespace euromilhoes
{
    class euromilhoes
    {
        private int nestrela = 0, nnumero = 0;
        private const string cruz = "x";
        private bool[] numeros = new bool[50];
        private bool[] estrela = new bool[12];

        public string Numeros(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumero--;
            }
            else if (nnumero < 5)
            {
                numeros[n] = true;
                nnumero++;
            }

            if (numeros[n]) return cruz;
            else return "";
        }
        public string Estrela(int n)
        {
            if (estrela[n])
            {
                estrela[n] = false;
                nestrela--;
            }
            else if (nestrela < 5)
            {
                estrela[n] = true;
                nestrela++;
            }

            if (estrela[n]) return cruz;
            else return "";
        }
        public string listanum
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 50; i++)
                    if (numeros[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }

        public string listaestrelas
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 12; i++)
                    if (estrela[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
    }
}
