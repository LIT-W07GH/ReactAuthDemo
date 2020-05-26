import React from 'react';
import axios from 'axios';

class SecretPage extends React.Component {
    state = {
        number: ''
    }

    componentDidMount = async () => {
        const { data } = await axios.get('/api/secret/random');
        this.setState({ number: data.number });
    }

    render() {
        return (
            <div>
                <h1>Secret page!!!</h1>
                {this.state.number && <h2>Secret number: {this.state.number}</h2>}
            </div>
        )
    }
}


export default SecretPage;