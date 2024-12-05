import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/HeaderComponent/Header";
import Footer from "./components/FooterComponent/Footer";
import Home from "./components/HomeComponent/Home";
import LoginComponent from "./components/LoginComponent/LoginComponent";
import ScheduleComponent from "./components/ScheduleComponent/ScheduleComponent";
import ErrorComponent from "./components/ErrorComponent/ErrorComponent";
import Register from "./components/Register/RegisterJ";

const App = () => {
  return (
    <Router>
      <Header />
      <main>
        <Routes>
          <Route path="/" element={<Home />} errorElement={<ErrorComponent />} />
          <Route path="/login" element={<LoginComponent />} errorElement={<ErrorComponent />}  />
          <Route path="/RegisterJ" element={<Register />} errorElement={<ErrorComponent />} />
          <Route path="/schedule" element={<ScheduleComponent />} errorElement={<ErrorComponent />} />
          
        </Routes>
      </main>
      <Footer />
    </Router>
  );
};

export default App;