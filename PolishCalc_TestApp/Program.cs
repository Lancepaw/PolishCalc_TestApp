using PolishCalcLib;

using static System.Console;

namespace PolishCalc_TestApp{
static class Program{

static void Main()
{	double res;
	string input, errMsg;
	PolishCalculator calc = new PolishCalculator();

	while( true )
	{	WriteLine( "Введите математическое выражение в польской записи. Для выхода введите Q" );

		input = ReadLine();

		if( input == "Q" || input == "q" )
			break;

		if( calc.Calculate( input, out res, out errMsg ) )
			WriteLine( $"Результат: { res }" ); else
			WriteLine( errMsg );
	}
	
}
	
}}