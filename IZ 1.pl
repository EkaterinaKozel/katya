factorial(X, Result) :-
     factorial(X,1, Result), !.
factorial(0, Acc, Result) :-
    Result = Acc, !.
factorial(X, Acc, Result):-
    AccN is Acc*X,
    XN is X - 1,
    factorial(XN, AccN, Result), !.

factorialSumCheck(Number):-
    factorialSumCheck(Number, Number, 0), !.
factorialSumCheck(0, Number, SumCurrent):-
    Number = SumCurrent, !.
NumberCurrent > 0,
    NumberCurrent is NumberCurrent div 10,
    Digit is NumberCurrent mod 10,
    Number > SumCurrent,

    factoria(Digit, DigitFac),
    SumCurrentN is SumCurrent + DigitFac,

    factorialSumCheck(NumberCurrentN, Number, SumCurrentN), !.

/* Поиск чисел */

% Максимальное значение для такого числа 7 * 9! = ‭2 540 160‬
factorions(Result):-
    factorions(3, 0, Result).

factorions(Number, S, Result) :-
    Number<2540160,
    factorialSumCheck(Number),
    write("Find number:"), write(Number), n1,

    SN is S + Number,
    NumberN is Number +1,
    factorions(NumberN, SN, Result),!.
