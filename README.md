Данная программа предназначена для поиска максимального пути от одной вершины графа к другой, проходящего через две заданные вершины и два заданных ребра.<br>
Программа включает два потока. Первичный поток осуществляет общее управление работой программы. Вторичный выполняет вычисления по стадиям (стадия – нахождение какого-либо очередного пути или цикла) и передает после каждой стадии результаты вычислений для использования их первичным потоком. Первичный поток визуализирут результаты вычислений каждой стадии.<br>
Программа обеспечивает ввод исходный данных из файла и с клавиатуры.<br>
Файл с исходными данными имеет вид:<br>
количество вершин<br>
матрица смежности<br>
начальная вершина пути<br>
конечная вершина пути<br>
первая вершина<br>
вторая вершина<br>
первое ребро<br>
второе ребро
