export interface IAddresses {
    id: number;
    streetName : string;
    streetNo : number;
    city: string;
    country : string;
    primary: boolean

}
export interface ICustomers {
    id: number;
    name: string;
    email: string;
    phoneNumber: string;
    addressList: IAddresses[]
} 

