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
    float money, perc;
    cout << "Введите начальный вклад: ";
    cin >> money;
    cout << "Введите число лет: ";
    cin >> year;
    cout << "Введите процентную ставку: ";
    cin >> perc;
    for (int x = 0; x < year; x++) {
        money *= (100.0 + perc) / 100;
    }
    cout << "Через "<< year <<" лет вы получите " << money << "денежных единиц";


    cout << '\n' << "Задание 4" << '\n';

}

