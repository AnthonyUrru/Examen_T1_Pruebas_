using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T1_Pinos.Pruebas
{
    [TestFixture]
    class Pinos_Pruebas
    {
        [Test]
        public void ObtenerPuntajeCaso1()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id=1,nombre="Juan"});
            sala_pinos.AddPlayers(new Jugadores { id=2, nombre = "Alexander" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(3,2);
            sala_pinos.Lanzar(4,2);
            //Juan = 10 + 3 + 1 = 14
            // Alexander = 7
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(0,2);
            sala_pinos.Lanzar(0,2);
            //Juan = 14 + 3 + 1 = 18
            //Alexander = 7 + 0 = 0
            sala_pinos.Lanzar(8,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(8,2);
            //Juan=18+10+2= 30
            //Alexander = 7 + 9 = 16
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(5,2);
            //Juan=30+2+3=   35
            //Alexander = 16 + 1 + 5 = 22
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(35, result);
            Assert.AreEqual(22, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso2()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Piero" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Raul" });
            //frame1
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(4,2);
            sala_pinos.Lanzar(4,2);
            //Piero=10+sgte_Tiro=20
            //Raul = 8
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(5,2);
            //Piero=20+10+sgte_Tiro1+sgte_Tiro2=36
            //Raul = 8 + 10 + sgte_Tiro = 22
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(2,2);
            //Piero=36+4+2=  42
            //Raul = 22 + 2 + 2 = 26
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(42, result);
            Assert.AreEqual(26, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso3()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Junior" });
            //frame1
            sala_pinos.Lanzar(10,1);
            //Junior=10+sgte_t1+sgte_t2=10+10+sgte_t2=10+10+10=30
            sala_pinos.Lanzar(10,1);
            //Junior=30+10+sgte_t1+sgte_t2= 30+10+sgte_t2=40+10+10= 60
            sala_pinos.Lanzar(10,1);
            //Junior=60+10+sgte_t1+sgte_t2=50+10+sgte_t2=70+10+10=90
            sala_pinos.Lanzar(10,1);
            //Junior=90+10+sgte_t1+sgte_t2=70+10+sgte_t2=100+10+10=120
            sala_pinos.Lanzar(10,1);
            //Junior = 120 + 10 + sgte_t1 + sgte_t2 = 90 + 10 + sgte_t2 = 130 + 10 + 10 = 150
            sala_pinos.Lanzar(10,1);
            //Junior=150+10+sgte_t1+sgte_t2=110+10+sgte_t2=160+10+10=180
            sala_pinos.Lanzar(10,1);
            //Junior=180+10+sgte_t1+sgte_t2=130+10+sgte_t2=190+10+10=210
            sala_pinos.Lanzar(10,1);
            //Junior=210+10+sgte_t1+sgte_t2=150+10+sgte_t2=220+10+10=240
            sala_pinos.Lanzar(10,1);
            //Junior=240+10+sgte_t1+sgte_t2=170+10+sgte_t2=250+10+10=270
            sala_pinos.Lanzar(10,1);
            //Junior=270+10+sgte_t1+sgte_t2=190+10+sgte_t2=280+10+10=300
            var result = sala_pinos.Puntaje(1);
            Assert.AreEqual(300, result);
 
        }
        [Test]
        public void ObtenerPuntajeCaso4()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Carlos" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Eduardo" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Carlos=10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro2=1010+10=30
            //Eduardo= 10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro2=1010+10=30
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Carlos=30+10+sgte_tiro1+sgte_tiro2=40+10+sgte_tiro2=40+10+5=55
            //Eduardo= 30+10+sgte_tiro1+sgte_tiro2=40+10+sgte_tiro2=40+10+6=56
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Carlos=55+10+sgte_tiro1+sgte_tiro2=65+5+1=71
            //Eduardo= 56+10+sgte_tiro1+sgte_tiro2=66+6+2=74
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(1,1); 
            sala_pinos.Lanzar(6,2);
            sala_pinos.Lanzar(2,2);
            //Carlos=71+5+1=77
            //Eduardo=74+6+2=82 
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(77, result);
            Assert.AreEqual(82, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso5()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Rosa" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Brigith" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Rosa =10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro2=1010+10=30
            //Brigith= 10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro2=10+10+2=22
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Rosa =30+10+sgte_tiro1+sgte_tiro2=40+10+sgte_tiro2=40+10+5=55
            //Brigith= 22+10+sgte_tiro1+sgte_tiro2=32+2+4=38
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(4,2);
            //Rosa =55+10+sgte_tiro1+sgte_tiro2=65+5+1=71
            //Brigith= 38+2+4=44
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(6,2);
            sala_pinos.Lanzar(2,2);
            //Rosa =71+5+1=77
            //Brigith=44+6+2=52
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(77, result);
            Assert.AreEqual(52, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso6()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Pedro" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Luis" });
            //frame1
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(6,2);
            sala_pinos.Lanzar(0,2);
            //Pedro=10+sgte_tiro=14
            //Luis=6
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(3,2);
            sala_pinos.Lanzar(3,2);
            //Pedro=14+10+sgte_tiro=14+10+1=25
            //Luis=6+3+3=12
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(8,2);
            sala_pinos.Lanzar(2,2);
            //Pedro=25+10+sgte_tiro=25+10+4=39
            //Luis=12+10+sgte_tiro=12+10+5=27
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(1,2);
            //Pedro=39+4+4=47
            //Luis=27+5+1=33
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(47, result);
            Assert.AreEqual(33, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso7()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Frank" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Adoni" });
            //frame1
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(0,1);
            sala_pinos.Lanzar(6,2);
            sala_pinos.Lanzar(3,2);
            //Frank=9+0=9
            //Adoni=6+3=9
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(3,2);
            sala_pinos.Lanzar(4,2);
            //Frank=9+10+sgte_Tiro=9+10+8=26
            //Adoni=9+3+4=16
            sala_pinos.Lanzar(8,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(4,2);
            sala_pinos.Lanzar(2,2);
            //Frank=26+10+sgte_Tiro=26+10+2=38
            //Adoni=16+4+2=22
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(5,2);
            //Frank=38+2+5=45
            //Adoni=22+10+sgte_Tiro=22+10+2=34
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(8,2);
            //Frank=45+3+3=51
            //Adoni=34+10+sgte_Tiro=34+10+10=54
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(10,2);
            //Frank=51+10+sgte_tiro=51+10+4=65
            //Adoni=54+10+sgte_Tiro1+sgte_tiro2=54+10+1+7=72
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(7,1);
            //Frank=65+4+4=73
            //Adoni=72+1+7=80
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(0,2);
            sala_pinos.Lanzar(9,2);
            //Frank=73+4+1=78
            //Adoni=80+0+9=89
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(2,2);
            //Frank=78 +10+sgte_tiro1+sgte_tiro2=78+10+10+sgte_tiro2=78+10+10=98
            //Adoni=89+1+2=92
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(9,2);
            sala_pinos.Lanzar(0,2);
            //Frank=98+10+ste_tiro1+sgte_tiro2=98+10+10+5=123
            //Adoni=92+9+0=101
            //-----------------frame extra-----------------------------
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(5,1);
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(123, result);
            Assert.AreEqual(101, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso8()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Neymar" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Ricardo" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(1,2);
            //Neymar=10+sgte_tiro1+sgte_tiro2=10+4+6=20
            //Ricardo=1+1=2
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(4,2);
            sala_pinos.Lanzar(4,2);
            //Neymar=20+10+sgte_tiro=20+10+2=32
            //Ricardo=2+4+4=10
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(4,2);
            sala_pinos.Lanzar(5,2);
            //Neymar=32+2+2=36
            //Ricardo=10+4+5=19
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(36, result);
            Assert.AreEqual(19, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso9()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Miguel" });
            //frame1
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(8,1);
            //Miguel=10+sgte_tiro=10+4=14
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(6,1);
            //Miguel=14+10+sgte_tiro=14+10+0=24
            sala_pinos.Lanzar(0,1);
            sala_pinos.Lanzar(10,1);
            //Miguel=24+10+sgte_tiro=24+10+7=41
            sala_pinos.Lanzar(7,1);
            sala_pinos.Lanzar(3,1);
            //Miguel=41+10+sgte_tiro=41+10+5=56
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,1);
            //Miguel=56+10+sgte_tiro=56+10+2=68
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(8,1);
            //Miguel=68+10+sgte_tiro=68+10+6=84
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(4,1);
            //Miguel=84+10+sgte_tiro=84+10+9=103
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(1,1);
            //Miguel=103+10+sgte_tiro=103+10+6=119
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(4,1);
            //Miguel=119+10+sgte_tiro=119+10+3=132
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(4,1);
            //Miguel=132+10+sgte_tiro=132+10+3=145
            //---------------frame extra-----------------------------
            sala_pinos.Lanzar(3,1);
            var result = sala_pinos.Puntaje(1);
            Assert.AreEqual(145, result);
        }
        [Test]
        public void ObtenerPuntajeCaso10()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Julian" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Camilo" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(2,2);
            //Julian=10+sgte_tiro1+sgte_tiro2=10+4+3=17
            //Camilo=2+2=4
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(8,2);
            //Julian=17+4+3=24
            //Camilo=4+10+sgte_tiro=4+10+1=15
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(3,2);
            //Julian=24+2+5=31
            //Camilo=15+1+3=19
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(31, result);
            Assert.AreEqual(19, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso11()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Pedro" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Luis" });
            sala_pinos.AddPlayers(new Jugadores { id = 3, nombre = "Ramiro" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            sala_pinos.Lanzar(10,3);
            //Pedro=10+sgte_tiro1+sgte_tiro2=10+5+4=19
            //Luis=10+sgte_tiro1+sgte_tiro2=18
            //Ramiro=10+sgte_tiro1+sgte_tiro2=16
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(2,2);
            sala_pinos.Lanzar(6,2);
            sala_pinos.Lanzar(3,3);
            sala_pinos.Lanzar(3,3);
            //Pedro=19+5+4=28
            //Luis=18+2+6=26
            //Ramiro=16+3+3=22
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            var result3 = sala_pinos.Puntaje(3);
            Assert.AreEqual(28, result);
            Assert.AreEqual(26, result2);
            Assert.AreEqual(22, result3);
        }
        [Test]
        public void ObtenerPuntajeCaso12()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Lisa" });
            //frame1
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(1,1);
            //Lisa=10+sgte_tiro=10+5=15
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,1);
            //Lisa=15+10+sgte_tiro=15+10+10=35
            sala_pinos.Lanzar(10,1);
            //Lisa=35+10+sgte_tiro1+sgte_tiro2=35+10+1+4=50
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(4,1);
            //Lisa=50+1+4=55
            var result = sala_pinos.Puntaje(1);
            Assert.AreEqual(55, result);
            
        }
        [Test]
        public void ObtenerPuntajeCaso13()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Romulo" });
            //frame1
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(9,1);
            //Romulo=10+sgte_tiro=10+6=16
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(4,1);
            //Romulo=16+10+sgte_tiro=16+10+5=31
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(5,1);
            //Romulo=31+10+sgte_tiro=31+10+1=42
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(2,1);
            //Romulo=42+1+2=45
            var result = sala_pinos.Puntaje(1);
            Assert.AreEqual(45, result);
            
        }
        [Test]
        public void ObtenerPuntajeCaso14()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Fernando" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Alicia" });
            //frame1
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Fernando=10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro=10+10+4=24
            //Alicia=10+sgte_tiro1+sgte_tiro2=10+10+sgte_tiro=10+10+8=28
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(10,2);
            //Fernando=24+10+sgte_tiro1+sgte_tiro2=24+10+4+6=44
            //Alicia=28+10+sgte_tiro1+sgte_tiro2=28+10+8+2=48
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(6,1);
            sala_pinos.Lanzar(8,2);
            sala_pinos.Lanzar(2,2);
            //Fernando=44+10+sgte_tiro=44+10+4=58
            //Alicia=48+10+sgte_tiro=48+10+5=63
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(1,2);
            //Fernando=58+4+4=66
            //Alicia=63+5+1=69
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(66, result);
            Assert.AreEqual(69, result2);
        }
        [Test]
        public void ObtenerPuntajeCaso15()
        {
            var sala_pinos = new Sala_Pinos();
            sala_pinos.AddPlayers(new Jugadores { id = 1, nombre = "Yuliana" });
            sala_pinos.AddPlayers(new Jugadores { id = 2, nombre = "Birna" });
            //frame1
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(2,2);
            //Yuliana=5+2=7
            //Birna=5+2=7
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(2,2);
            //Yuliana=7+5+2=14
            //Birna=7+5+2=14
            sala_pinos.Lanzar(5,1);
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(2,2);
            //Yuliana=14+5+2=21
            //Birna=14+5+2=21
            sala_pinos.Lanzar(3,1);
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(1,2);
            sala_pinos.Lanzar(3,2);
            //Yuliana=21+3+1=25
            //Birna=24+1+3=25
            sala_pinos.Lanzar(9,1);
            sala_pinos.Lanzar(1,1);
            sala_pinos.Lanzar(10,2);
            //Yuliana=25+10+sgte_tiro=25+10+10=45
            //Birna=25+10+stgte_tiro1+sgte_tiro2=25+10+3+4=37
            sala_pinos.Lanzar(10,1);
            sala_pinos.Lanzar(3,2);
            sala_pinos.Lanzar(4,2);
            //Yuliana=45+10+sgte_tiro1+sgte_tiro2=45+10+2+4=61
            //Birna=37+3+4=44
            sala_pinos.Lanzar(2,1);
            sala_pinos.Lanzar(4,1);
            sala_pinos.Lanzar(5,2);
            sala_pinos.Lanzar(1,2);
            //Yuliana=61+2+4=67
            //Birna=44+5+1=50
            var result = sala_pinos.Puntaje(1);
            var result2 = sala_pinos.Puntaje(2);
            Assert.AreEqual(67, result);
            Assert.AreEqual(50, result2);
        }
    }
}
