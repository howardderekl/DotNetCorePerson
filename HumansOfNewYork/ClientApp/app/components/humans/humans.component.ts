import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'humans',
    template: require('./humans.component.html')
})
export class HumansComponent {
    public persons: Person[];

    constructor(http: Http) {
        http.get('/api/person').subscribe(result => {
            this.persons = result.json();
        });
    }
}

interface Person {
    name: string;
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

