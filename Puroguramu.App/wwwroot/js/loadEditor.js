document.addEventListener('DOMContentLoaded', (evt) => {
    loadEditor("ProposalEditor", "Proposal");
    loadEditor("ProposalEditor", "Model");
    loadEditor("ProposalAnswerEditor", "Answer");
});

function loadEditor(proposalEditorId, proposalInputId) {
    const proposalEditor = ace.edit(proposalEditorId);
    
    if (!proposalEditor) return;
    
    const proposalInput = document.getElementById(proposalInputId);
    
    if (!proposalInput) return;
    
    proposalEditor.setTheme("ace/theme/xcode");
    proposalEditor.session.setMode("ace/mode/csharp");

    proposalInput.value = proposalEditor.session.getValue();
    proposalEditor.session.on('change', (evt) => {
        proposalInput.value = proposalEditor.session.getValue();
    });
}
