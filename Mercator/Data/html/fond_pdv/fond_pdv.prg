PROCEDURE doc_hist
lparameters le_jou

msg_txt=IIF(users.langue='N','Welke datum ?','Quelle date ?')
do do_form with 'askdates',.F.,.F.
if msg_bout=2
	return
endif

do yHistoricDoc with m.le_jou

ENDPROC


PROCEDURE last_doc
IF (TYPE('m.ident_der_v')='C') AND !EMPTY(m.ident_der_v)
	l_id=left(m.ident_der_v,10)
	le_journal=substr(m.ident_der_v,11,5)
	la_piece=val(substr(m.ident_der_v,16,10))
	DO yShowDoc WITH l_id,le_journal,la_piece
ELSE
	stop(IIF(users.langue='N','Geen document gevonden !','Aucun document trouvé !'))
ENDIF

ENDPROC