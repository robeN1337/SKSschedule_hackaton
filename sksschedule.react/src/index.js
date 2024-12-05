import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';

import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

import ErrorPage from './components/ErrorComponent/ErrorComponent';
import LoginComponent from './components/LoginComponent/LoginComponent';
import ScheduleComponent from './components/ScheduleComponent/ScheduleComponent';


const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <ErrorPage />
  },
  {
    path: "/Login",
    element: <LoginComponent />,
    errorElement: <ErrorPage />
  },
  {
    path: "/Schedule",
    element: <ScheduleComponent />,
    errorElement: <ErrorPage />
  },
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <RouterProvider router={router} />
);

