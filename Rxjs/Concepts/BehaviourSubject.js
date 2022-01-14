/*One of the variants of Subjects is the BehaviorSubject, which has a notion of "the current value".
It stores the latest value emitted to its consumers, and whenever a new Observer subscribes, it will immediately receive the "current value" from the BehaviorSubject*/

//BehaviorSubjects are useful for representing "values over time". For instance, an event stream of birthdays is a Subject, but the stream of a person's age would be a BehaviorSubject.*/

import { BehaviorSubject } from 'rxjs';
const subject = new BehaviorSubject(0); // 0 is the initial value

subject.subscribe({
    next: (v) => console.log(`observerA: ${v}`)
});

subject.next(1);
subject.next(2);

subject.subscribe({
    next: (v) => console.log(`observerB: ${v}`)
});

subject.next(3);

// Logs
// observerA: 0
// observerA: 1
// observerA: 2
// observerB: 2
// observerA: 3
// observerB: 3