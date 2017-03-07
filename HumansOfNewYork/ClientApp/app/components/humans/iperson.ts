import {IInterest} from './iinterest';
import {IPicture} from './ipicture';

export interface IPerson {

    firstName: string;
    lastName: string;
    age: number;
    street: string;
    city: string;
    state: string;
    zip: string;
    picture: IPicture;
    interests: IInterest[];
    fullName: string;
}