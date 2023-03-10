import { ICustomers, IAddresses } from "./Types/TypeInterfaces";


export const getCustomers = async () => {
  const customerRes = await fetch("http://localhost:5269/api/Customers");
  const customersData = (await customerRes.json()) as ICustomers[];
  return customersData;
};

export const getAddresses = async () => {
    const addressesRes = await fetch("http://localhost:5269/api/Addresses");
    const addressesData = (await addressesRes.json()) as IAddresses[];
    return addressesData;
  };

export const deleteCust= async (customerId: number) => {
    const response = await fetch(
      `http://localhost:5269/api/Customers/${customerId}`,
      {
        method: "DELETE",
      }
    );
};

export const getCustomerById = async ( customerId : number ) => {
    const customerRes = await fetch(`http://localhost:5269/api/Customers/${customerId}`);
    const customerData = (await customerRes.json()) as ICustomers;
    return customerData;
  };

