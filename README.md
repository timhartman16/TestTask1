# TestTask1 and TestTask2

## Задание 1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Дополнительно к работоспособности оценим:

- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

## Задание 2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

------

Решение первого задания находится в репозитории, а решение второго задания будет описано ниже.

-----

У нас есть таблица продуктов Products, которая состоит из номера продукта(id) и его названия(name).

![image](https://user-images.githubusercontent.com/83501316/191320453-36a3814c-eac6-49b6-9249-f5a6fd8e585b.png)

И нас есть таблица категорий Categories, которая состоит из номера категории(id) и ее названия(name).

![image](https://user-images.githubusercontent.com/83501316/191320697-0f164e24-c22b-4584-9a0a-1dcff11b23ed.png)

Также есть смежная таблица категорий продуктов ProductsCategories, в которой хранятся связи продуктов и категорий (Product_id и Category_id - внешние ключи).

![image](https://user-images.githubusercontent.com/83501316/191324288-4a1b0f79-74f0-4b9e-8657-4bf175274059.png)

Требуемый для выполнения задания запрос:

SELECT Products.name, Categories.name

FROM Products Products

LEFT JOIN ProductsCategories ProductsCategories 
          ON Products.id = ProductsCategories.Product_id
          
LEFT JOIN Categories Categories 
          ON ProductsCategories.Category_id = Categories.id

![image](https://user-images.githubusercontent.com/83501316/191324876-43b842ac-6073-4e47-86a2-db537253df09.png)
