import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import "./App.css";
import Customers from "./Components/Customers";
import Navbar from "./Components/Navbar";


function App() {

  return (
    <div className="App">

      <Router>
        <Navbar />
        <Routes>
          <Route path="/" element={<Customers />}></Route>


        </Routes>

      </Router>

    </div>);
}

export default App;
