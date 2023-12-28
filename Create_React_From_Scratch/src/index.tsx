import React, { StrictMode } from "react";
import {createRoot} from "react-dom/client"
import App from './App';
import store from "./Redux/store";
import { Provider } from "react-redux";

const rootContainer = document.querySelector('#root');

if (rootContainer===null) throw new Error('There is no root container');

createRoot(rootContainer).render(
    <StrictMode>
        <Provider store={store}>
        <App />
        </Provider>
    </StrictMode>

)