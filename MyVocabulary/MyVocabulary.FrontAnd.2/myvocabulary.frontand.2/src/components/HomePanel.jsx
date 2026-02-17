import React from 'react';
import Login from './Login.jsx'
import RegisterPanel from './RegisterPanel.jsx';
import { useState } from 'react'

function HomePanel() {
    var HomePanel = {
        position: 'absolute',
        margin: '0px',
        padding: '0px',
        left: '50%',
        top: '30%',
        transform: 'translate(-50%,-50%)',
        height: '20%',
        backgroundColor: 'rgba(199, 244, 250)',
        border: '3px solid rgba(222, 195,204)'
    };

   

    
    const [currentPage, setCurrentPage] = useState('login');
    if (currentPage === 'login')
    {
        return (<div style={HomePanel}>
            <Login registerBattonCallBack={setCurrentPage} />
        </div>);
    }
    if (currentPage === 'register') {
        return (<div style={HomePanel}>
            <RegisterPanel />
        </div>);
    }
}

export default HomePanel;