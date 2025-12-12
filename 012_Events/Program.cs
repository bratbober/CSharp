// Подія - це механізм,
// який дозволяє об'єктам повідомляти інші об'єкти про те,
// що щось сталося.

// Подія - це ситуація,
// при виникненні якої виконується дія(метод)
// або декілька дій(методів).

// Видавець - це об'єкт, який оголошує подію
// Підписник - це об'єкт, який підписується на подію видавця

using _012_Events;

Counter counter = new Counter(); // Видавець(publisher)
Handler1 handler1 = new Handler1(); // Підписник(subscriber)
Handler2 handler2 = new Handler2(); // Підписник(subscriber)
Handler3 handler3 = new Handler3(); // Підписник(subscriber)
counter.eventCount += handler1.Message; // Підписка на подію
counter.eventCount += handler2.Message; // Підписка на подію
counter.eventCount += handler3.Message; // Підписка на подію
counter.Count();  