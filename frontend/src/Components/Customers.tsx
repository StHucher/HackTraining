import { useEffect, useState } from "react";
import { deleteCust, getAddresses, getCustomerById, getCustomers } from "../Api";
import { IAddresses, ICustomers } from "../Types/TypeInterfaces";
import CustomersTable from "./CustomersTable";
import "../StyleSheets/CustomersSS.css";
// sfc
const customers = () => {

    const [customers, SetCustomers] = useState<ICustomers[]>([]);
    const [addresses, SetAddresses] = useState<IAddresses[]>([]);



    const getData = async () => {
        const customersFromApi = await getCustomers();
        const addressesFromApi = await getAddresses();
        SetCustomers(customersFromApi);
        SetAddresses(addressesFromApi)
        console.log({ customersFromApi, addressesFromApi });
    };

    const customerDetails = async (id: number) => {
       const customer = await getCustomerById(id);
    };


    const deleteCustomer = async (id: number) => {
        await deleteCust(id);
        SetCustomers(customers.filter(cust => {
            return cust.id !== id;
        }))
    };


    useEffect(() => {
        getData();
    }, []);

    return (<div className="customers">

        <CustomersTable customers={customers} customerDetails={customerDetails} deleteCustomer={deleteCustomer} />
    </div>
    );
}

export default customers;