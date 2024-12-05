import React from "react";
import "./Home.css";


const newsData = [
  { title: "Обновлено расписание на декабрь", date: "01.12.2024", description: "Проверьте обновленные расписания на ближайший месяц." },
  { title: "День открытых дверей", date: "05.12.2024", description: "Приглашаем абитуриентов и их родителей посетить наш колледж." },
];

const Home = () => {
  return (
    <div className="home">
      <section className="hero">
        <h1>Добро пожаловать на сайт колледжа</h1>
        <p>Здесь вы найдете актуальное расписание занятий.</p>
      </section>
      
    </div>
  );
};

export default Home;
