import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { IPerson} from '../humans/iperson';

@Component({
    selector: 'human-delay',
    template: require('./humandelay.component.html')
})
export class HumanDelayComponent {
    public persons: IPerson[];
    public listFilter: string = "";
    public imageWidth: number = 50;
    public imageMargin: number = 2;

    constructor(http: Http) {
        http.get('/api/person/getdelayedresponse').subscribe(result => {
            this.persons = result.json();
        });
    }
}