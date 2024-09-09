﻿using CommandSolucao.devices;

namespace CommandSolucao.Commands
{
    internal class LigarLampada : Command
    {
        private Lampada lampada;

        public LigarLampada(Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void desfazer()
        {
            //no metodo desfazer, chamar o metodo desligar 
            this.lampada.desligar();

            //chamar o metodo toString() para feedback
            this.lampada.tostring();
        }

        public void executar()
        {
            //no metodo desfazer, chamar o metodo ligar 
            this.lampada.ligar();
            //chamar o metodo toString() para feedback
            this.lampada.tostring();
        }
    }
}