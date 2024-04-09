document.addEventListener('DOMContentLoaded', (evt) => {

    const proposalEditor = ace.edit("ProposalEditor");
    const proposalInput = document.getElementById("Proposal");

    proposalEditor.setTheme("ace/theme/xcode");
    proposalEditor.session.setMode("ace/mode/csharp");

    proposalInput.value = proposalEditor.session.getValue();
    proposalEditor.session.on('change', (evt) => {
        proposalInput.value = proposalEditor.session.getValue();
    });
});