﻿namespace _12Interfaces_exercicio
{
    public class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo em Xml");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome Xml");
        }
    }
}
