import React from 'react';
function LoginPanel() {
    var LoginPanel = {
        position: 'absolute',
        margin: '0px',
        padding: '0px',
        left: '50%',
        top: '30%',
        transform: 'translate(-50%,-50%)',
        height: '20%',
        backgroundColor: 'rgba(199, 244, 250)'
    };
    return (<div style = {LoginPanel}> 
             <h1>Hello METANIT.COM</h1>
            </div>);
}

export default LoginPanel;