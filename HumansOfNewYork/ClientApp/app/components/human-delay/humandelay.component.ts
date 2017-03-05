import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'human-delay',
    template: require('./humandelay.component.html')
})
export class HumanDelayComponent {
    public persons: Person[];

    constructor(http: Http) {
        http.get('/api/person/getdelayedresponse').subscribe(result => {
            this.persons = result.json();
        });
    }
}

interface Person {
    firstName: string;
    lastName: string;
    age: number;
    street: string;
    city: string;
    state: string;
    zip: string;
    picture: number;
    interests: Interest[];
}

interface Interest {
    description: string;
}