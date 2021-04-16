import React from 'react';

interface OmaApiTestiState {
    nimi: string;
}

class OmaApiTesti extends React.Component<{}, OmaApiTestiState> {

    constructor(props: {}) {
        super(props);

        this.state = { nimi: "" };
        console.log("OmaApiTesti.constructor");
    }

    componentDidMount() {

        console.log("OmaApiTesti.componentDidMount");

        fetch('https://localhost:44338/api/v1/asiakkaat/maa/Finland')
            .then(response => response.json())
            .then(json => {
                console.log(json);

                // ruudun päivitys
                this.setState({ nimi: json[0].companyName });
                console.log("OmaApiTesti -> setState()");
            });
    }

    render() {

        console.log("OmaApiTesti.render");

        return <>
            <h1>OmaApiTesti</h1>
            <p>Asiakasnimi: {this.state.nimi}</p>
        </>;
    }
}

export default OmaApiTesti;
