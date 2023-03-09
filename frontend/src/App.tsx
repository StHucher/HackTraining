import { useEffect, useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";
import { ICustomers } from "./Types/TypeInterfaces";
import { getCustomers } from "./Api";

function App() {
  const [customers, SetCustomers] = useState<ICustomers[]>([]);

  const getData = async () => {
    const customersFromApi = await getCustomers();
    SetCustomers(customersFromApi)
    console.log({ customersFromApi });
  };

  useEffect(() => {
    getData();
  }, []);
  return (
  <div className="App">

{
  customers.map(x => {
   return(
    <>
    {x.name}

    </>
   );
  })
}

  </div>);
}

export default App;
