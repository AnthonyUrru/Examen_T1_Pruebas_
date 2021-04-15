using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T1_Pinos
{
    public class Sala_Pinos
    {
        private readonly List<Jugadores> jugadores_pinos;
        public Sala_Pinos(){
            jugadores_pinos = new List<Jugadores>();
            }
        public void AddPlayers(Jugadores jugador)
        {
            jugadores_pinos.Add(jugador);
        }
        public void Lanzar(int num, int id)
        {
            var player = jugadores_pinos.Where(o => o.id == id).FirstOrDefault();
            if (num == 10)
            {
                player.puntaje=player.puntaje+num.
            }
            player.puntaje = player.puntaje + num;
        }
        public int Puntaje(int id)
        {
            var player = jugadores_pinos.Where(o => o.id == id).FirstOrDefault();
            return player.puntaje;
        }
    }
}
