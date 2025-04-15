# Опис використаних принципів:
1) DRY (Don't Repeat Yourself): Код використовує інтерфейси та спільні методи для спільних дій.
Наприклад, метод Display() для відображення ціни валюти використовується в класах [UkrainianHryvnia, Euro, and Dollar](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L11C1-L58C2),
замість того, щоб повторювати код для кожного класу.
2) KISS (Keep It Simple, Stupid): Код має просту структуру і його легко зрозуміти. Кожен клас має чітко визначену сферу відповідальності, а методи реалізують лише необхідний функціонал.
3) SOLID:
   - Single Responsibility Principle: Кожен клас має одну конкретну відповідальність, наприклад, [Product](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L59C1-L85C2) відповідає за роботу з продуктом, а [Warehouse](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L86C1-L102C2) для роботи зі складом.
   - Open/Closed Principle: Код готовий до розширення новими класами, наприклад, [a new currency](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L4C1-L10C2), але закриті для змін у вже існуючих класах.
   - Liskov Substitution Principle: Об'єкти можуть бути замінені їхніми підтипами без зміни бажаної функціональності. Наприклад, [classes UkrainianHryvnia, Euro,  Dollar](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L11C1-L58C2) імплементують [IMoney](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L4C1-L10C2) і може використовуватися будь-де, де очікується об'єкт типу IMoney.
4) YAGNI (You Ain't Gonna Need It): Код містить лише той функціонал, який потрібен на даний момент. Наприклад, зниження ціни на товар реалізовано в [Product class](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L59C1-L85C2), але ніякого іншого непотрібного функціоналу не передбачено.
5) Program to Interfaces not Implementations: Код взаємодіє з об'єктами через інтерфейси ([IMoney](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L4C1-L10C2), [Product](https://github.com/vt231pak/kpz/blob/main/lab1/lab1/Program.cs#L59C1-L85C2)) що забезпечує гнучкість і легкість змін.
