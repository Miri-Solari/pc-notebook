// Lab1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;


int main()
{
    setlocale(LC_ALL, "Russian");
    float temp;
    int first1, second1, first2, second2, funt, shill, pens, del = 1;
    char dummychar;

    cout << "Задание 1" << '\n';
    cout << "Стремительно прохожу,\nРаспахивая дверь \nРозового туннеля, \nУпираясь в тупик.\n Ты выдыхаешь : -\"Глубже!\".\n" << '\n';
    
    cout << "Задание 2" << '\n';
    cout << "Введите температуру в градусах Цельсия: ";
    cin >> temp;
    cout << "\nТемпература в градусах Фаренгейта = " << temp * 9 / 5 + 32 << '\n' << '\n';
    
    cout << "Задание 3" << '\n';
    cout << "Введите первую дробь: ";
    cin >> first1 >> dummychar >> second1;
    cout << "Введите вторую дробь: ";
    cin >> first2 >> dummychar >> second2;
    for (int x = second1 * second2; x > 1; x--) {
        if (second1 * second2 % x == 0 && (first1 * second2 + first2 * second1) % x == 0) {
            del = x;
            break;
        }
    }
    if ((first1 * second2 + first2 * second1) % (second1 * second2) == 0) {
        cout << "Сумма = " << (first1 * second2 + first2 * second1) / (second1 * second2) << '\n' << '\n';
    }
    else {
        cout << "Сумма = " << (first1 * second2 + first2 * second1) / del << '/' << (second1 * second2) / del << '\n' << '\n';
    }
    
    cout << "Задание 4" << '\n';
    cout << "Введите количество фунтов: ";
    cin >> funt;
    cout << "Задайте количество шиллингов: ";
    cin >> shill;
    cout << "Установите количество пенсов: ";
    cin >> pens;
    cout << "Десятичных фунтов: £" << funt << '.' << (shill * 12 + pens) * 10 / 24 << '\n' << '\n';
    
    cout << "Задание 5" << '\n';
    cout << "Введите число десятичных фунтов: ";
    cin >> funt >> dummychar >> pens;
    cout << "Эквивалентная сумма в старой форме записи: £" << funt << '.' << pens * 24 / 10 / 12   << '.' << (pens * 24 / 10 - pens * 24 / 10 / 12 * 12);


}

