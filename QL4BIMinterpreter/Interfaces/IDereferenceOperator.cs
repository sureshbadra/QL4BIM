/*
Copyright (c) 2017 Chair of Computational Modeling and Simulation (CMS), 
Prof. André Borrmann, 
Technische Universität München, 
Arcisstr. 21, D-80333 München, Germany

This file is part of QL4BIMinterpreter.

QL4BIMinterpreter is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
any later version.

QL4BIMinterpreter is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with QL4BIMinterpreter. If not, see <http://www.gnu.org/licenses/>.

*/

using System.Collections.Generic;
using QL4BIMinterpreter.QL4BIM;

namespace QL4BIMinterpreter
{
    public interface IDereferenceOperator
    {
        //only symbols and simple types in operators, no nodes
        //symbolTable, parameterSym1, ..., returnSym

        void ReferenceSet(SetSymbol parameterSym1, string[] references, RelationSymbol returnSym);
        void ReferenceRelAtt(RelationSymbol parameterSym1, string[] references, RelationSymbol returnSym);

        List<QLEntity[]> ResolveReferenceTuplesIn(IEnumerable<QLEntity[]> tuples, int attributeIndex, bool replace, string referenceName);
        IEnumerable<QLEntity[]> ResolveReferenceSetIn(IEnumerable<QLEntity> entites, string referenceName);
    }
}
