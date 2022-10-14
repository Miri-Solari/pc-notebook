// LAB_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <iomanip>
using namespace std;

void print_piro(int n) {
    for (int x = 0; x < 39; x++) {
        if (x < 39 - n) {
            cout << ' ';
        }
        else {
            cout << 'x';
        }
    }
}

int fact(int n) {
    int f = 1;
    for (int x = 1; x <= n; x++) {
        f *= x;
    }
    return f;
}

int main()
{
    int piro = 1;
    setlocale(LC_ALL, "Russian");
    cout << "Задание 1" << '\n';
    for (int x = 0; x < 20; x++) {
        print_piro(piro);
        cout << '\n';
        piro += 2;
    }


    cout << '\n' << '\n' << "Задание 2" << '\n';
    int inp = 0;
    cout << "Введите число: ";
    cin >> inp;
    for (int x = 0; inp != 0; x++) {
        cout << "Его факториал: " << fact(inp) << '\n' << '\n';
        cout << "Введите число: ";
        cin >> inp;
    }
    cout << "Вы ввели 0, работа алгоритма закончена!" << '\n' << '\n';


    cout << '\n' << "Задание 3" << '\n';
    int year;
    double money, perc;
    cout << "Введите начальный вклад: ";
    cin >> money;
    cout << "Введите число лет: ";
    cin >> year;
    cout << "Введите процентную ставку: ";
    cin >> perc;
    for (int x = 0; x < year; x++) {
        money *= (100.0 + perc) / 100;
    }
    cout << "Через "<< year <<" лет вы получите " << money << " д. ед." << "\n\n";


    cout << '\n' << "Задание 4" << '\n';
    int first;
    double percent, fin, sum;
    cout << "Введите сумму кредита: ";
    cin >> sum;
    cout << "Введите первоначальный взнос: ";
    cin >> first;
    cout << "Введите срок кредитования в годах: ";
    cin >> year;
    cout << "Введите фиксированный процент: ";
    cin >> percent;
    sum -= first;
    cout << '\n';
    fin = sum * (percent / 100 / 12 * pow(1.0 + percent / 100 / 12, year * 12) / (pow(1.0 + percent / 100 / 12, year * 12) - 1));
    sum = fin * 12 * year;
    for (int x = 1; x <= year; x++) {
        cout << "За " << x << " год вы заплатите: " << fixed << setprecision(4) << fin*12 << '\n';
        if (sum - fin * 12*x > 0){
            cout << "До закрытия кридите останется заплатить: " << fixed << setprecision(4) << sum - fin * 12 * x << '\n';
        }
        else {
            cout << "Примите искренние поздравления, вы закрыли кредит!!!" << '\n';
        }

    }
    cout << "Общая сумма выплат: " << sum << '\n';

    cout << '\n' << "Задание 5" << '\n';
    int funt, shill, pens, funts, shills, penss, x = 2;
    char dummychar, yn;
    cout << "Желаете начать работу(y/n)? ";
    cin >> yn;
    cout << "Введите 1 сумму: £";
    cin >> funts >> dummychar >> shills >> dummychar >> penss;
    while (yn != 'n') {
        cout << "Введите " << x << " сумму: £";
        x++;
        cin >> funt >> dummychar >> shill >> dummychar >> pens;
        penss += pens;
        if (penss > 11) {
            shills++;
            penss -= 12;
        }
        shills += shill;
        if (shills > 19) {
            funts++;
            shills -= 20;
        }
        funts += funt;
        cout << "Всего: £" << funts << '.' << shills << '.' << penss << '\n';
        cout << "Продолжить (y/n)? ";
        cin >> yn;
        cout << '\n';
    }
    cout << "Работа программы закончена!!!\n\n";

}

