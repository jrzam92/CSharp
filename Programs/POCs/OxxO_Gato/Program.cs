using System;
using System.Xml.Serialization;

namespace OxxO_Gato
{
    public class Program
    {
       static char[,] tableroNumeros = new char[,]
            { { '1','2','3'},
                { '4','5','6'},
                {'7','8','9' } };
        static char[,] tableroJuegoInicial = new char[,]
           { { '1','2','3'},
                { '4','5','6'},
                {'7','8','9' } };
        static int jugador = 2;
        static int turnos = 0;
        static int input = 0;
        static bool inputCorrecto = true;
       
        static void Main(string[] args)
        {
            do
            {

           
            Console.WriteLine("Jugador 1 tendra ficha X");
            Console.WriteLine("Jugador 2 tendra ficha O");
             
            try
            {
            
                if (jugador == 2)
                {
                    jugador = 1;
                }
                else {
                    jugador = 2;
                }
                     
                    
                    do
                    {
                        CreacionTablero();
                        Console.WriteLine("\nJugador {0}, escoja el casillero a poner su ficha ...",jugador);
                        try
                        {
                            input = Convert.ToInt32(Console.ReadLine());
                           
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Favor de solo colocar numeros");
                        }

                        char[] cadaSigno = { 'X', 'O' };
                        #region Validacion de ganador o empate de jugadores
                        foreach (char signo in cadaSigno) {
                            PonerXoO(jugador, input);
                            if ((tableroNumeros[0, 0] == signo && tableroNumeros[0, 1] == signo && tableroNumeros[0, 2] == signo)
                                || (tableroNumeros[1, 0] == signo && tableroNumeros[1, 1] == signo && tableroNumeros[1, 2] == signo)
                                || (tableroNumeros[2, 0] == signo && tableroNumeros[2, 1] == signo && tableroNumeros[2, 2] == signo)
                                || (tableroNumeros[0, 0] == signo && tableroNumeros[1, 0] == signo && tableroNumeros[2, 0] == signo)
                                || (tableroNumeros[0, 1] == signo && tableroNumeros[1, 1] == signo && tableroNumeros[2, 1] == signo)
                                || (tableroNumeros[0, 2] == signo && tableroNumeros[1, 2] == signo && tableroNumeros[2, 2] == signo)
                                || (tableroNumeros[0, 0] == signo && tableroNumeros[1, 1] == signo && tableroNumeros[2, 2] == signo)
                                 || (tableroNumeros[0, 2] == signo && tableroNumeros[1, 1] == signo && tableroNumeros[2, 0] == signo))
                            {
                                if (signo == 'X' || signo == 'O')
                                {
                                    CreacionTablero();
                                    Console.WriteLine("Felicitaciones!!! el Jugador {0} a ganado....", jugador);
                                    Console.WriteLine("Presiona cualquier tecla para reiniciar el juego ...");
                                    Console.Read();
                                    Reset();
                                }
                               
                            }
                            else if (turnos == 9) {
                                CreacionTablero();
                                Console.WriteLine("Hubo un empate!!! XD XD XD");
                                Console.WriteLine("Presiona cualquier tecla para reiniciar el juego ...");
                                Console.Read();
                                Reset();
                            }
                            
                        }
                        #endregion

                        #region Validacion de valores ingresados con correctos
                        if (input == 1 && tableroNumeros[0, 0] == '1') inputCorrecto = true;
                        else if (input == 2 && tableroNumeros[0, 1] == '2') inputCorrecto = true;
                        else if (input == 3 && tableroNumeros[0, 2] == '3') inputCorrecto = true;
                        else if (input == 4 && tableroNumeros[1, 0] == '4') inputCorrecto = true;
                        else if (input == 5 && tableroNumeros[1, 1] == '5') inputCorrecto = true;
                        else if (input == 6 && tableroNumeros[1, 2] == '6') inputCorrecto = true;
                        else if (input == 7 && tableroNumeros[2, 0] == '7') inputCorrecto = true;
                        else if (input == 8 && tableroNumeros[2, 1] == '8') inputCorrecto = true;
                        else if (input == 9 && tableroNumeros[2, 2] == '9') inputCorrecto = true;
                        else { Console.WriteLine("Favor de ingresar otro número"); }
                        #endregion

                    } while (!inputCorrecto);

                
            }
            catch (Exception)
            {

                Console.WriteLine("Favor de solo colocar numeros");
            }
            } while (true); 

        }
        /// <summary>
        /// Creacion de tablero
        /// </summary>
        public static void CreacionTablero() {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t           |           |");
            Console.WriteLine("\t     {0}     |     {1}     |     {2}     ", tableroNumeros[0,0], tableroNumeros[0, 1], tableroNumeros[0, 2]);
            Console.WriteLine("\t___________|___________|___________");
            Console.WriteLine("\t           |           |");
            Console.WriteLine("\t     {0}     |     {1}     |     {2}     ", tableroNumeros[1, 0], tableroNumeros[1, 1], tableroNumeros[1, 2]);
            Console.WriteLine("\t___________|___________|___________");
            Console.WriteLine("\t     {0}     |     {1}     |     {2}     ", tableroNumeros[2, 0], tableroNumeros[2, 1], tableroNumeros[2, 2]);
            Console.WriteLine("\t           |           |");
            turnos++;
        }
        /// <summary>
        /// Reseteo de tablero
        /// </summary>
        public static void Reset()
        {
            tableroNumeros = tableroJuegoInicial;
            CreacionTablero();
        }
        /// <summary>
        /// Se coloca la ficha X o O dependiendo de que jugador sea ...
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="input"></param>
        public static void PonerXoO(int jugador,int input)
        {
             char signo =' ';
            if(jugador==1)
            {
                signo = 'X';
            }else if (jugador == 2)
            {
                signo = 'O';
            }
            switch (input)
            {
                case 1: tableroNumeros[0, 0]=signo;  break;
                case 2: tableroNumeros[0, 1]=signo;  break;
                case 3: tableroNumeros[0, 2]=signo;  break;
                case 4: tableroNumeros[1, 0]=signo;  break;
                case 5: tableroNumeros[1, 1]=signo;  break;
                case 6: tableroNumeros[1, 2]=signo;  break;
                case 7: tableroNumeros[2, 0]=signo;  break;
                case 8: tableroNumeros[2, 1]= signo;  break;
                case 9: tableroNumeros[2, 2] = signo;  break;
            }
        }

    }
}
