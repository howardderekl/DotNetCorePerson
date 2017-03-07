import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { IPerson } from './iperson';

@Component({
    selector: 'pm-persons',
    template: require('./person-list.component.html')
})
export class PersonListComponent {
    public persons: IPerson[];
    public listFilter: string = "";
    public imageWidth: number = 50;
    public imageMargin: number = 2;

    constructor(http: Http) {
        http.get('/api/person').subscribe(result => {
            this.persons = result.json();
        });
    }
}


