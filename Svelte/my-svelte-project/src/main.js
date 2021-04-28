import App from './App.svelte';

const app = new App({
	target: document.body,
	props: {
		name: 'maailma'
	}
});

export default app;