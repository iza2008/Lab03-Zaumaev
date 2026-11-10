// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500; // пополнение
// Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200; // покупка
// Console.WriteLine($"После покупки на 200: {balance}");

// balance *= 1.05; // начисление 5% процентов
// Console.WriteLine($"После начисления 5%: {balance}");

// balance /= 2; // разделили счёт пополам с партнёром
// Console.WriteLine($"После деления пополам: {balance}");

// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
// Console.WriteLine($"После этого weekNumber = {weekNumber}");

// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");

// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;

// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2,0 (не двойка): {isNotFailing}");

// Console.WriteLine();
// Console.WriteLine("Логические операторы");

// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;

// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");

// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");

// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($" Вычисляется: {label}");
//     return value;
// }
//  Console.WriteLine("Проверяем || (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");

// Console.WriteLine();
// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");

// Console.WriteLine();
// Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");

// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5>3 && 2<4 || false = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false = {logicResultParens}");

// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = benefitInput == 1;

// bool hasGoodCertificate = averageGrade >= 4.0;
// bool hasGoodExam = examScore >= 60;
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4,0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");

// Console.WriteLine();
// Console.WriteLine("Задание 1. Чётное или нечётное");

// Console.Write("Введите целое число: ");
// int numberToCheck = int.Parse(Console.ReadLine());
// bool isEven = numberToCheck % 2 == 0;
// Console.WriteLine($"Число {numberToCheck} чётное: {isEven}");

Console.WriteLine();
Console.WriteLine("Задание 2. Инкремент в выражениях");

int boxes = 4;
// Постфиксный ++ сначала присваивает переменной старое значение boxes, затем увеличивает boxes.
int postfixValue = boxes++;
Console.WriteLine($"boxes++: в postfixValue попало старое значение {postfixValue}, boxes теперь {boxes}");

//Префиксный ++ сначала увеличивает boxes и только потом сохраняет новое значение.
int prefixValue = ++boxes;
Console.WriteLine($"++boxes: сначала boxes стало {boxes}, это значение попало в prefixValue = {prefixValue}");

int points = 20;
// Слева направо: points++ даёт 20 и повышает points до 21, а ++points повышает его до 22 и даёт 22.
int combinedValue = points++ * 2 + ++points;
Console.WriteLine($"points++ * 2 + ++points = {combinedValue}; points после выражения = {points}");

// Console.WriteLine();
// Console.WriteLine("Задание 3. Калькулятор скидки");

// Console.Write("Введите сумму покупки: ");
// double purchaseAmount = double.Parse(Console.ReadLine()!);

// Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
// int loyaltyCardInput = int.Parse(Console.ReadLine()!);
// bool hasLoyaltyCard = loyaltyCardInput == 1;

// Console.Write("Введите количество товаров в чеке: ");
// int itemCount = int.Parse(Console.ReadLine()!);

// bool amountIsEnough = purchaseAmount >= 3000;
// bool itemCountIsEnough = itemCount >= 3;
// bool amountAndItemsAreEnough = amountIsEnough && itemCountIsEnough;
// bool eligibleForDiscount = amountAndItemsAreEnough || hasLoyaltyCard;

// Console.WriteLine($"Сумма покупки >= 3000: {amountIsEnough}");
// Console.WriteLine($"Товаров в чеке >= 3: {itemCountIsEnough}");
// Console.WriteLine($"Сумма и количество подходят одновременно: {amountAndItemsAreEnough}");
// Console.WriteLine($"Есть карта постоянного клиента: {hasLoyaltyCard}");
// Console.WriteLine($"Положена скидка: {eligibleForDiscount}");

// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($"  Вычисляется: {label}");
//     return value;
// }
