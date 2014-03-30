// ---------------------------------------------------------------------
// Base Processor class, auto-generated									
// 	Do NOT edit this file												
// 	Additional methods should be defined in another file				
// ---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using crosspascal.ast.nodes;

namespace crosspascal.ast
{
	public abstract partial class Processor
	{
		//	Complete interface to be implemented by any specific AST processor	

		
		public virtual bool Visit(FixmeNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(NotSupportedNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(EmptyNode node)
		{
			Visit((Node) node);
			return true;
		}
				
		public virtual bool Visit(NodeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(StatementList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(TypeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(IntegralTypeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(IdentifierList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(DeclarationList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(EnumValueList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(TranslationUnit node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(ProgramNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.uses);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(LibraryNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.uses);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(UnitNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.@interface);
			traverse(node.implementation);
			traverse(node.initialization);
			traverse(node.finalization);
			return true;
		}
		
		public virtual bool Visit(PackageNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.requires);
			traverse(node.contains);
			return true;
		}
		
		public virtual bool Visit(UnitItem node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(UsesItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(RequiresItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(ContainsItem node)
		{
			Visit((UnitItem) node);
			return true;
		}
		
		public virtual bool Visit(ExportItem node)
		{
			Visit((UnitItem) node);
			traverse(node.formalparams);
			return true;
		}
		
		public virtual bool Visit(Section node)
		{
			Visit((Node) node);
			traverse(node.decls);
			return true;
		}
		
		public virtual bool Visit(CodeSection node)
		{
			Visit((Section) node);
			traverse(node.block);
			return true;
		}
		
		public virtual bool Visit(ProgramBody node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(RoutineBody node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(InitializationSection node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(FinalizationSection node)
		{
			Visit((CodeSection) node);
			return true;
		}
		
		public virtual bool Visit(DeclarationSection node)
		{
			traverse(node.uses);
			Visit((Section)node);
			return true;
		}
		
		public virtual bool Visit(InterfaceSection node)
		{
			Visit((DeclarationSection) node);
			return true;
		}
		
		public virtual bool Visit(ImplementationSection node)
		{
			Visit((DeclarationSection) node);
			return true;
		}
		
		public virtual bool Visit(AssemblerRoutineBody node)
		{
			Visit((RoutineBody) node);
			return true;
		}
		
		public virtual bool Visit(Declaration node)
		{
			Visit((Node) node);
			traverse(node.type);
			return true;
		}
		
		public virtual bool Visit(LabelDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(ValueDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(VarDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(ParamDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(VarParamDeclaration node)
		{
			Visit((ParamDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ConstParamDeclaration node)
		{
			Visit((ParamDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(OutParamDeclaration node)
		{
			Visit((ParamDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(ConstDeclaration node)
		{
			Visit((ValueDeclaration) node);
			traverse(node.init);
			return true;
		}
		
		public virtual bool Visit(EnumValue node)
		{
			Visit((ConstDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(TypeDeclaration node)
		{
			Visit((Declaration) node);
			return true;
		}
		
		public virtual bool Visit(ProceduralType node)
		{
			Visit((TypeNode) node);
			traverse(node.@params);
			traverse(node.funcret);
			traverse(node.returnVar);
			traverse(node.Directives);
			return true;
		}
		
		public virtual bool Visit(MethodType node)
		{
			Visit((ProceduralType) node);
			return true;
		}
		
		public virtual bool Visit(CallableDeclaration node)
		{
			Visit((Declaration) node);
			traverse(node.Type);
			traverse(node.Directives);
			return true;
		}
		
		public virtual bool Visit(RoutineDeclaration node)
		{
			Visit((CallableDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(MethodDeclaration node)
		{
			Visit((CallableDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(RoutineDefinition node)
		{
			Visit((RoutineDeclaration)node);
			traverse(node.body); 
			return true;
		}
		
		public virtual bool Visit(MethodDefinition node)
		{
			Visit((MethodDeclaration)node);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(RoutineDirectives node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(ImportDirectives node)
		{
			Visit((RoutineDirectives) node);
			return true;
		}
		
		public virtual bool Visit(MethodDirectives node)
		{
			Visit((RoutineDirectives) node);
			return true;
		}
		
		public virtual bool Visit(CompositeDeclaration node)
		{
			Visit((TypeDeclaration) node);
			traverse(node.Type);
			return true;
		}
		
		public virtual bool Visit(ClassDeclaration node)
		{
			Visit((CompositeDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(InterfaceDeclaration node)
		{
			Visit((CompositeDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(CompositeType node)
		{
			Visit((TypeNode) node);
			traverse(node.sections);
			return true;
		}
		
		public virtual bool Visit(ClassType node)
		{
			Visit((CompositeType) node);
			traverse(node.self);
			return true;
		}
		
		public virtual bool Visit(InterfaceType node)
		{
			Visit((CompositeType) node);
			traverse(node.guid);
			return true;
		}
		
		public virtual bool Visit(ClassRefType node)
		{
		//	Do not traverse this node! circular dependency
		//	traverse(node.reftype);
			return true;
		}

		public virtual bool Visit(RecordRefType node)
		{
			//	Do not traverse this node! circular dependency
			//	traverse(node.reftype);
			return true;
		}

		public virtual bool Visit(ScopedSection node)
		{
			Visit((Section) node);
			traverse(node.fields);
			return true;
		}
		
		public virtual bool Visit(ScopedSectionList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(FieldDeclaration node)
		{
			Visit((ValueDeclaration) node);
			return true;
		}
		
		public virtual bool Visit(VariantDeclaration node)
		{
			Visit((FieldDeclaration) node);
			traverse(node.varfields);
			return true;
		}
		
		public virtual bool Visit(VarEntryDeclaration node)
		{
			Visit((FieldDeclaration) node);
			traverse(node.tagvalue);
			traverse(node.fields);
			return true;
		}
		
		public virtual bool Visit(PropertyDeclaration node)
		{
			Visit((FieldDeclaration) node);
			traverse(node.specifiers);
			return true;
		}
		
		public virtual bool Visit(ArrayProperty node)
		{
			Visit((PropertyDeclaration) node);
			traverse(node.indexes);
			return true;
		}
		
		public virtual bool Visit(PropertySpecifiers node)
		{
			Visit((Node) node);
			traverse(node.index);
			traverse(node.stored);
			traverse(node.@default);
			return true;
		}
		
		public virtual bool Visit(Statement node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(LabelStatement node)
		{
			Visit((Statement) node);
			traverse(node.stmt);
			return true;
		}
		
		public virtual bool Visit(EmptyStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(BreakStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(ContinueStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(Assignment node)
		{
			Visit((Statement) node);
			traverse(node.lvalue);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(GotoStatement node)
		{
			Visit((Statement) node);
			return true;
		}
		
		public virtual bool Visit(IfStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.thenblock);
			traverse(node.elseblock);
			return true;
		}
		
		public virtual bool Visit(ExpressionStatement node)
		{
			Visit((Statement) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(CaseSelector node)
		{
			Visit((Statement) node);
			traverse(node.list);
			traverse(node.stmt);
			return true;
		}
		
		public virtual bool Visit(CaseStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.selectors);
			traverse(node.caseelse);
			return true;
		}
		
		public virtual bool Visit(LoopStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.block);
			return true;
		}
		
		public virtual bool Visit(RepeatLoop node)
		{
			Visit((LoopStatement) node);
			return true;
		}
		
		public virtual bool Visit(WhileLoop node)
		{
			Visit((LoopStatement) node);
			return true;
		}
		
		public virtual bool Visit(ForLoop node)
		{
			Visit((LoopStatement) node);
			traverse(node.var);
			traverse(node.start);
			traverse(node.end);
			return true;
		}
		
		public virtual bool Visit(BlockStatement node)
		{
			Visit((Statement) node);
			traverse(node.stmts);
			return true;
		}
		
		public virtual bool Visit(WithStatement node)
		{
			Visit((Statement) node);
			traverse(node.with);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(TryFinallyStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			traverse(node.final);
			return true;
		}
		
		public virtual bool Visit(TryExceptStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			traverse(node.final);
			return true;
		}
		
		public virtual bool Visit(ExceptionBlock node)
		{
			Visit((Statement) node);
			traverse(node.onList);
			traverse(node.@default);
			return true;
		}
		
		public virtual bool Visit(RaiseStatement node)
		{
			Visit((Statement) node);
			traverse(node.lvalue);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(OnStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			return true;
		}
		
		public virtual bool Visit(AssemblerBlock node)
		{
			Visit((BlockStatement) node);
			return true;
		}
		
		public virtual bool Visit(Expression node)
		{
			Visit((Node) node);
			traverse(node.Type);
			traverse(node.Value);
			traverse(node.ForcedType);
			return true;
		}
		
		public virtual bool Visit(EmptyExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(ExpressionList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(ConstExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(StructuredConstant node)
		{
			Visit((ConstExpression) node);
			traverse(node.exprlist);
			return true;
		}
		
		public virtual bool Visit(ArrayConst node)
		{
			Visit((StructuredConstant) node);
			return true;
		}
		
		public virtual bool Visit(RecordConst node)
		{
			Visit((StructuredConstant) node);
			return true;
		}
		
		public virtual bool Visit(FieldInitList node)
		{
			Visit((ExpressionList) node);
			foreach (Node n in node.nodes)
				traverse(n);
			return true;
		}
		
		public virtual bool Visit(FieldInit node)
		{
			Visit((ConstExpression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(ConstIdentifier node)
		{
			Visit((ConstExpression) node);
			return true;
		}
		
		public virtual bool Visit(Literal node)
		{
			Visit((ConstExpression) node);
			return true;
		}
		
		public virtual bool Visit(OrdinalLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(IntLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(CharLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(BoolLiteral node)
		{
			Visit((OrdinalLiteral) node);
			return true;
		}
		
		public virtual bool Visit(StringLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(RealLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(PointerLiteral node)
		{
			Visit((Literal) node);
			return true;
		}
		
		public virtual bool Visit(ConstantValue node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(IntegralValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(StringValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(RealValue node)
		{
			Visit((ConstantValue) node);
			return true;
		}
		
		public virtual bool Visit(BinaryExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(SetIn node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.set);
			return true;
		}
		
		public virtual bool Visit(SetRange node)
		{
			Visit((BinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ArithmethicBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return true;
		}
		
		public virtual bool Visit(Subtraction node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Addition node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Product node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Division node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Quotient node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Modulus node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ShiftRight node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ShiftLeft node)
		{
			Visit((ArithmethicBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return true;
		}
		
		public virtual bool Visit(LogicalAnd node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalOr node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalXor node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Equal node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(NotEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LessThan node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LessOrEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(GreaterThan node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(GreaterOrEqual node)
		{
			Visit((LogicalBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(TypeBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.types);
			return true;
		}
		
		public virtual bool Visit(TypeIs node)
		{
			Visit((TypeBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(RuntimeCast node)
		{
			Visit((TypeBinaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(UnaryExpression node)
		{
			Visit((Expression) node);
			return true;
		}
		
		public virtual bool Visit(SimpleUnaryExpression node)
		{
			Visit((Expression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(UnaryPlus node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(UnaryMinus node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(LogicalNot node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(AddressLvalue node)
		{
			Visit((SimpleUnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(Set node)
		{
			Visit((UnaryExpression) node);
			traverse(node.setelems);
			return true;
		}
		
		public virtual bool Visit(LvalueExpression node)
		{
			Visit((UnaryExpression) node);
			return true;
		}
		
		public virtual bool Visit(ExprAsLvalue node)
		{
			Visit((LvalueExpression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(StaticCast node)
		{
			Visit((LvalueExpression) node);
			traverse(node.casttype);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(UnresolvedId node)
		{
			Visit((LvalueExpression) node);
			traverse(node.id);
			return true;
		}
		
		public virtual bool Visit(UnresolvedCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.func);
			traverse(node.args);
			return true;
		}
		
		public virtual bool Visit(ArrayAccess node)
		{
			Visit((LvalueExpression) node);
			traverse(node.lvalue);
			traverse(node.acessors);
			traverse(node.array);
			return true;
		}
		
		public virtual bool Visit(PointerDereference node)
		{
			Visit((LvalueExpression) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(InheritedCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.call);
			return true;
		}
		
		public virtual bool Visit(RoutineCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.func);
			traverse(node.args);
			return true;
		}
		
		public virtual bool Visit(ObjectAccess node)
		{
			Visit((LvalueExpression) node);
			traverse(node.obj);
			return true;
		}
		
		public virtual bool Visit(Identifier node)
		{
			Visit((LvalueExpression) node);
			return true;
		}
		
		public virtual bool Visit(TypeNode node)
		{
			Visit((Node) node);
			return true;
		}
		
		public virtual bool Visit(UnresolvedType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(UnresolvedVariableType node)
		{
			Visit((VariableType) node);
			return true;
		}
		
		public virtual bool Visit(UnresolvedIntegralType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(UnresolvedOrdinalType node)
		{
			Visit((VariableType) node);
			return true;
		}
		
		public virtual bool Visit(VariableType node)
		{
			Visit((TypeNode) node);
			return true;
		}
		
		public virtual bool Visit(MetaclassType node)
		{
			Visit((VariableType) node);
			traverse(node.baseType);
			return true;
		}
		
		public virtual bool Visit(EnumType node)
		{
			Visit((VariableType) node);
			traverse(node.enumVals);
			return true;
		}
		
		public virtual bool Visit(RangeType node)
		{
			Visit((VariableType) node);
			traverse(node.min);
			traverse(node.max);
			return true;
		}
		
		public virtual bool Visit(ScalarType node)
		{
			Visit((VariableType) node);
			return true;
		}
		
		public virtual bool Visit(IntegralType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(IntegerType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(SignedIntegerType node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedIntegerType node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt8Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt16Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt32Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(UnsignedInt64Type node)
		{
			Visit((UnsignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt8Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt16Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt32Type node)
		{
			Visit((SignedIntegerType) node);
			return true;
		}
		
		public virtual bool Visit(SignedInt64Type node)
		{
			Visit((IntegerType) node);
			return true;
		}
		
		public virtual bool Visit(BoolType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(CharType node)
		{
			Visit((IntegralType) node);
			return true;
		}
		
		public virtual bool Visit(RealType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(FloatType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(DoubleType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(ExtendedType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(CurrencyType node)
		{
			Visit((RealType) node);
			return true;
		}
		
		public virtual bool Visit(StringType node)
		{
			Visit((ScalarType) node);
			return true;
		}
		
		public virtual bool Visit(FixedStringType node)
		{
			Visit((StringType) node);
			traverse(node.expr);
			return true;
		}
		
		public virtual bool Visit(VariantType node)
		{
			Visit((VariableType) node);
			traverse(node.actualtype);
			return true;
		}
		
		public virtual bool Visit(PointerType node)
		{
			Visit((ScalarType) node);
			traverse(node.pointedType);
			return true;
		}
		
		public virtual bool Visit(StructuredType node)
		{
			Visit((VariableType) node);
			traverse(node.basetype);
			return true;
		}
		
		public virtual bool Visit(ArrayType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(SetType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(FileType node)
		{
			Visit((StructuredType) node);
			return true;
		}
		
		public virtual bool Visit(RecordType node)
		{
			Visit((StructuredType) node);
			traverse(node.compTypes);
			return true;
		}
	}
}
