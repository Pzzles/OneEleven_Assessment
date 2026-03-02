document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('test-form');
    const output = document.getElementById('output');

    form.addEventListener('submit', async (e) => {
        e.preventDefault();

        const email = document.getElementById('email').value.trim();
        const url = document.getElementById('url').value.trim();

        // build test service URL
        const testUrl = `https://yhxzjyykdsfkdrmdxgho.supabase.co/functions/v1/application-task?url=${encodeURIComponent(url)}&email=${encodeURIComponent(email)}`;
        output.textContent = 'Testing...';

        try {
            const res = await fetch(testUrl);
            const text = await res.text();
            output.textContent = `Status: ${res.status}\n\n${text}`;
        } catch (err) {
            output.textContent = `Error: ${err.message}`;
        }
    });
});