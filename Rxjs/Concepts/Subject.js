/*
1.A Subject is like an Observable, but can multicast to many Observers. Subjects are like EventEmitters: they maintain a registry of many listeners.


2.Every Subject is an Observable. Given a Subject, you can subscribe to it, providing an Observer, 
which will start receiving values normally.From the perspective of the Observer, it cannot tell whether the Observable execution is coming from a plain unicast Observable or a Subject

3. Every Subject is an Observer. It is an object with the methods next(v), error(e), and complete(). To feed a new value to the Subject, just call next(theValue), 
and it will be multicasted to the Observers registered to listen to the Subject.

*/

import { Subject, from } from 'rxjs';

const subject = new Subject<number>();

subject.subscribe({
    next: (v) => console.log(`observerA: ${v}`)
});
subject.subscribe({
    next: (v) => console.log(`observerB: ${v}`)
});

const observable = from([1, 2, 3]);

observable.subscribe(subject); // You can subscribe providing a Subject

// Logs:
// observerA: 1
// observerB: 1
// observerA: 2
// observerB: 2
// observerA: 3
// observerB: 3


//With the approach above, we essentially just converted a unicast Observable execution to multicast, through the Subject.This demonstrates how Subjects are the only way of making any Observable execution be shared to multiple Observers.

